using System;
using OrangeShotStudio.Network;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class TickRateDependedInterpolator
    {
        private readonly int _size;
        private History<GameSnapshotSample> _snapshotSamples;
        private GameData _interpolatedResult;

        public TickRateDependedInterpolator(GameDataFactory gameDataFactory, int size)
        {
            if (size < 3)
                throw new ArgumentException("Size must be greater than 2");
            _size = size;
            var array = new GameSnapshotSample[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new GameSnapshotSample(gameDataFactory.CreateMessage());
            }

            _snapshotSamples = new History<GameSnapshotSample>(array);
            _interpolatedResult = gameDataFactory.CreateMessage();
        }

        public void SetCurrentGameData(GameData currentState, int tick, int tickDuration)
        {
            if (currentState == null)
                return;
            //todo возможно стоит перезаписывать текущий снапшот если предудащая запись отличается по тикрейту
            if (_snapshotSamples.LastTick >= tick)
                return;

            var sample = _snapshotSamples.Get(tick);
            sample.SetSample(currentState, tick);
            _snapshotSamples.Put(sample, tick);
        }

        public GameData Interpolate()
        {
            GameSnapshotSample baseSample = null;
            GameSnapshotSample nextSample = null;
            float normalizedValue = 1;
            for (int i = 0; i < _size - 1; i++)
            {
                var baseOffset = _size - 1 - i;
                var nextOffset = _size - 2 - i;
                var baseSampleIndex = _snapshotSamples.LastTick - baseOffset;
                var nextSampleIndex = _snapshotSamples.LastTick - nextOffset;
                var lastSampleIndex = _snapshotSamples.LastTick;
                baseSample = _snapshotSamples.Get(baseSampleIndex);
                nextSample = _snapshotSamples.Get(nextSampleIndex);
                var lastSample = _snapshotSamples.Get(lastSampleIndex);
                normalizedValue = (Environment.TickCount - lastSample.SampleTime) /
                                  (float)(nextSample.SampleTime - baseSample.SampleTime);
                if (normalizedValue > 1)
                    Debug.LogError(
                        $"$index:{i}, b:{baseSample.Tick} sample:{baseSample.SampleTime}, n:{nextSample.Tick} sample:{nextSample.SampleTime}, lastSample:{lastSample.SampleTime}, norm:{normalizedValue}");
                else
                {
                    Debug.Log(
                        $"$index:{i}, b:{baseSample.Tick} sample:{baseSample.SampleTime}, n:{nextSample.Tick} sample:{nextSample.SampleTime}, lastSample:{lastSample.SampleTime}, norm:{normalizedValue}");
                    break;
                }
            }

            if (baseSample != null)
                _interpolatedResult.World.Interpolate(baseSample.GameData.World, nextSample.GameData.World,
                    normalizedValue);
            return _interpolatedResult;
        }

        public void Dispose()
        {
            for (int i = 0; i < _snapshotSamples.Array.Length; i++)
            {
                _snapshotSamples.Array[i].GameData.Dispose();
            }

            _interpolatedResult.Dispose();
        }
    }
}