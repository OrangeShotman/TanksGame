using System.Collections.Generic;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Network;
using OrangeShotStudio.Network.Messages;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class InputStorage : IInputStorage<GameData>
    {
        private readonly IMessageDataFactory<GameData> _messageDataFactory;
        private readonly int _inputHistorySize;
        private readonly Dictionary<int, History<GameData>> _inputs;
        
        public InputStorage(IMessageDataFactory<GameData> messageDataFactory, int inputHistorySize)
        {
            _messageDataFactory = messageDataFactory;
            _inputHistorySize = inputHistorySize;
            _inputs = new Dictionary<int, History<GameData>>();
        }

        public void AddInput(int userId, GameData input)
        {
            if (!_inputs.TryGetValue(userId, out var history))
            {
                var array = new GameData[_inputHistorySize];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = _messageDataFactory.CreateMessage();
                }
                history = new History<GameData>(array);
                _inputs[userId] = history;
            }
            var cache = history.Get(input.ApplyToTick);
            input.CopyTo(cache);
            history.Put(cache, input.ApplyToTick);
        }

        public bool TryGetInput(int userId, int tick, out GameData input)
        {
            input = default;
            if (_inputs.TryGetValue(userId, out var history))
            {
                var inputSample = history.Get(tick);
                if (inputSample == null)
                    return false;
                if (inputSample.ApplyToTick != tick)
                    return false;
                input = inputSample;
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