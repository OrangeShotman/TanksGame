using System;
using OrangeShotStudio.Network;
using OrangeShotStudio.TanksGame.Multiplayer;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public class InterpolatorByHistory<T>
    {
        private readonly ITargetFrameCalculator<T> _targetFrameCalculator;
        private readonly IInterpolationStrategy<T> _interpolationStrategy;
        private readonly IFrameCopier<T> _frameCopier;
        private readonly float _normalTickDuration;
        private readonly float _fastTickDuration;
        private readonly int _maxLag;
        private T _interpolatedState;
        private int? _baseTick;
        private float _baseTime = -1;
        private float _currentTickDuration;

        public InterpolatorByHistory(T interpolatedState,
            ITargetFrameCalculator<T> targetFrameCalculator,
            IInterpolationStrategy<T> interpolationStrategy,
            IFrameCopier<T> frameCopier,
            float normalTickDuration,
            float fastTickDuration, int maxLag)
        {
            _targetFrameCalculator = targetFrameCalculator;
            _interpolationStrategy = interpolationStrategy;
            _frameCopier = frameCopier;
            _normalTickDuration = normalTickDuration;
            _fastTickDuration = fastTickDuration;
            _maxLag = maxLag;
            _interpolatedState = interpolatedState;
        }

        public T GetInterpolatedSnapshot(History<T> history, float time)
        {
            if (history == null || history.LastTick < 1)
                return _interpolatedState;
            if (!_baseTick.HasValue)
            {
                return ResetBaseTick(history, time);
            }

            var targetBaseState = _targetFrameCalculator.GetTargetBaseState(history);
            int baseTickDelta = (int)((time - _baseTime) / _currentTickDuration);
            float newBaseTime = _baseTime + baseTickDelta * _currentTickDuration;
            int newBaseTick = _baseTick.Value + baseTickDelta;
            if (targetBaseState - newBaseTick > _maxLag)
            {
                Debug.LogError($"targetBaseState:{targetBaseState}, newBaseTick{newBaseTick}, time:{time}");
                return ResetBaseTick(history, time);
            }

            if (history.LastTick <= newBaseTick)
            {
                Debug.LogError(
                    $"LastTick:{history.LastTick}, targetBaseState:{targetBaseState}, newBaseTick{newBaseTick}, time:{time}");
                return ResetBaseTick(history, time);
            }

            if (targetBaseState - newBaseTick > 1 && Math.Abs(_currentTickDuration - _normalTickDuration) < 0.000001)
            {
                _currentTickDuration = _fastTickDuration;
                Debug.LogError(
                    $"targetBaseState:{targetBaseState}, newBaseTick{newBaseTick}, fast tick duration:{_currentTickDuration}");
            }
            else if (targetBaseState - newBaseTick <= 1 &&
                     Math.Abs(_currentTickDuration - _fastTickDuration) < 0.000001)
            {
                _currentTickDuration = _normalTickDuration;
                Debug.LogError(
                    $"targetBaseState:{targetBaseState}, newBaseTick{newBaseTick}, normal tick duration:{_currentTickDuration}");
            }


            float normalizedTime = (time - newBaseTime) / _currentTickDuration;
            _baseTime = newBaseTime;
            _baseTick = newBaseTick;
            var baseState = history.Get(_baseTick.Value);
            var nextState = history.Get(_baseTick.Value + 1);
            _interpolationStrategy.Interpolate(_interpolatedState, baseState, nextState, normalizedTime);
            return _interpolatedState;
        }


        private T ResetBaseTick(History<T> history, float time)
        {
            _baseTick = _targetFrameCalculator.GetTargetBaseState(history);
            _baseTime = time;
            _currentTickDuration = _normalTickDuration;
            _frameCopier.Copy(history.Get(_baseTick.Value), _interpolatedState);
            return _interpolatedState;
        }
    }
}