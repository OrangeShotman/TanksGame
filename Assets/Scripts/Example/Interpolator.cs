using System;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class Interpolator
    {
        private GameSnapshotSample _baseSample;
        private GameSnapshotSample _nextSample;
        private GameData _interpolatedSample;
        private int _delta;

        public Interpolator(GameData baseSample, GameData nextSample, GameData interpolatedSample)
        {
            _interpolatedSample = interpolatedSample;
            _baseSample = new GameSnapshotSample(baseSample);
            _nextSample = new GameSnapshotSample(nextSample);
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
            var normalizedValue = Mathf.Clamp01((Environment.TickCount - _nextSample.SampleTime) / (float)_delta);
            _interpolatedSample.World.Interpolate(_baseSample.GameData.World, _nextSample.GameData.World,
                normalizedValue);
            return _interpolatedSample;
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