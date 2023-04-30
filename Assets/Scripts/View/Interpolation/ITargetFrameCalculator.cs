using OrangeShotStudio.Network;
using OrangeShotStudio.TanksGame.Multiplayer;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public interface ITargetFrameCalculator<T>
    {
        int GetTargetBaseState(History<T> history);
        int GetMaxAllowedTick(History<T> history);
    }

    public class PredictedTargetFrameCalculator : ITargetFrameCalculator<GameData>
    {
        public int GetTargetBaseState(History<GameData> history)
        {
            return history.LastTick - 1;
        }

        public int GetMaxAllowedTick(History<GameData> history)
        {
            return history.LastTick;
        }
    }

    public class ServerTargetFrameCalculator : ITargetFrameCalculator<GameData>
    {
        private int _previousServerTick;
        private History<int> _history;
        private int _correction;

        public ServerTargetFrameCalculator()
        {
            ResetHistory();
        }

        public int GetTargetBaseState(History<GameData> history)
        {
            var currentServerTick = history.Get(history.LastTick).ServerTick;
            if (_previousServerTick != currentServerTick)
            {
                var delta = currentServerTick - _previousServerTick;
                _history.Put(delta, _history.LastTick + 1);
                _previousServerTick = currentServerTick;
                _correction = (int)Mathf.Ceil(delta);
            }

            return history.Get(history.LastTick).ServerTick - _correction;
        }

        public int GetMaxAllowedTick(History<GameData> history)
        {
            return history.Get(history.LastTick).ServerTick;
        }

        private void ResetHistory()
        {
            var array = new int [StaticSettings.TickRate * 1];
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = 1;
            }

            _history = new History<int>(array);
            _correction = 1;
        }
    }
}