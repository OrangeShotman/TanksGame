using System.Collections.Generic;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Network;
using OrangeShotStudio.Network.Messages;
using OrangeShotStudio.Network.Pools;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class InputStorage : IInputStorage<GameData>
    {
        private readonly IMessageDataFactory<GameData> _messageDataFactory;
        private readonly int _inputHistorySize;
        private readonly Dictionary<int, History<PoolObject<GameData>>> _inputs;
        
        public InputStorage(IMessageDataFactory<GameData> messageDataFactory, int inputHistorySize)
        {
            _messageDataFactory = messageDataFactory;
            _inputHistorySize = inputHistorySize;
            _inputs = new Dictionary<int, History<PoolObject<GameData>>>();
        }

        public void AddInput(int userId, PoolObject<GameData>input)
        {
            if (!_inputs.TryGetValue(userId, out var history))
            {
                history = new History<PoolObject<GameData>>(_inputHistorySize);
                _inputs[userId] = history;
            }

            var cachedInput = history.Get(input.Value.ApplyToTick);
            if(cachedInput != null)
                cachedInput.Dispose();
            history.Put(input, input.Value.ApplyToTick);
        }

        public bool TryGetInput(int userId, int tick, out GameData input)
        {
            input = default;
            if (_inputs.TryGetValue(userId, out var history))
            {
                var inputSample = history.Get(tick);
                if (inputSample == null)
                    return false;
                if (inputSample.Value.ApplyToTick != tick)
                    return false;
                input = inputSample.Value;
                return true;
            }

            return false;
        }

        public void RemoveTill(int userId, int tick)
        {
            
        }

        public void Dispose()
        {
            foreach (var input in _inputs)
            {
                foreach (var gameData in input.Value)
                {
                    gameData.Dispose();
                }
            }
        }
    }
}