using System;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class Interpolator
    {
        private GameSnapshotSample _baseSample;
        private GameSnapshotSample _nextSample;
        private GameData _interpolatedSample;
        private int _delta;

        public Interpolator(GameDataFactory gameDataFactory)
        {
            _interpolatedSample = gameDataFactory.CreateMessage();
            _baseSample = new GameSnapshotSample(gameDataFactory.CreateMessage());
            _nextSample = new GameSnapshotSample(gameDataFactory.CreateMessage());
        }

        public void UpdateNextState(GameData currentState, int tick)
        {
            if(currentState == null)
                return;
            if(_nextSample.Tick >= tick)
                return;
            (_baseSample, _nextSample) = (_nextSample, _baseSample);
            _nextSample.SetSample(currentState, tick);
            _delta = _nextSample.SampleTime - _baseSample.SampleTime;
        }

        public GameData Interpolate()
        {
            var normalizedValue = (Environment.TickCount - _nextSample.SampleTime) / (float)_delta;
            _interpolatedSample.World.Interpolate(_baseSample.GameData.World, _nextSample.GameData.World,
                normalizedValue);
            return _interpolatedSample;
        }

        public void Dispose()
        {
            _baseSample.GameData.Dispose();
            _nextSample.GameData.Dispose();
        }

        private class GameSnapshotSample
        {
            public GameData GameData { get; private set; }
            public int SampleTime { get; private set; }
            public int Tick { get; private set; }

            public GameSnapshotSample(GameData gameData)
            {
                GameData = gameData;
            }

            public void SetSample(GameData gameData, int tick)
            {
                gameData.CopyTo(GameData);
                SampleTime = Environment.TickCount;
                Tick = tick;
            }
        }
    }
}