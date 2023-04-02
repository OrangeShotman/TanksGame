using System.Collections.Generic;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;

namespace Game.Tests
{
    public class ServerGameLogicFactory : IGameLogicSystemsFactory<GameData>
    {
        private readonly BaseSystem<GameData> _playerHandlerSystem;

        public ServerGameLogicFactory(BaseSystem<GameData> playerHandlerSystem)
        {
            _playerHandlerSystem = playerHandlerSystem;
        }
        public List<BaseSystem<GameData>> CreateLogic(IInputStorage<GameData> inputStorage)
        {
            var systems = new List<BaseSystem<GameData>>()
            {
                _playerHandlerSystem,
                new MovementSystem(inputStorage)
            };
            return systems;
        }
    }
}