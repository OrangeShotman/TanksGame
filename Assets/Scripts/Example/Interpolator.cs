using System;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class Interpolator<T> where T : IInterpolatable<T>
    {
        private readonly IInterpolationStrategy<T> _interpolationStrategy;
        private GameSnapshotSample<T> _baseSample;
        private GameSnapshotSample<T> _nextSample;
        private T _interpolatedResult;
        private int _delta;

        public Interpolator(T interpolatableBase, T interpolatableNext, T interpolatedResult,
            IInterpolationStrategy<T> interpolationStrategy)
        {
            _interpolationStrategy = interpolationStrategy;
            _interpolatedResult = interpolatedResult;
            _baseSample = new GameSnapshotSample<T>(interpolatableBase);
            _nextSample = new GameSnapshotSample<T>(interpolatableNext);
        }

        public void UpdateNextState(T currentState, int tick)
        {
            if (currentState == null)
                return;
            if (_nextSample.Tick >= tick)
                return;
            (_baseSample, _nextSample) = (_nextSample, _baseSample);
            _nextSample.SetSample(currentState, tick);
            _delta = _nextSample.SampleTime - _baseSample.SampleTime;
        }

        public T Interpolate()
        {
            var normalizedValue = (Environment.TickCount - _nextSample.SampleTime) / (float)_delta;
            _interpolationStrategy.Interpolate(_interpolatedResult, _baseSample.GameData, _nextSample.GameData,
                normalizedValue);
            return _interpolatedResult;
        }

        public void Dispose()
        {
            _baseSample.GameData.Dispose();
            _nextSample.GameData.Dispose();
            _interpolatedResult.Dispose();
        }
    }
}