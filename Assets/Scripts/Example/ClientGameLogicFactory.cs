using System.Collections.Generic;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;

namespace Game.Tests
{
    public class ClientGameLogicFactory : IGameLogicSystemsFactory<GameData>
    {
        public List<BaseSystem<GameData>> CreateLogic(IInputStorage<GameData> inputStorage)
        {
            var systems = new List<BaseSystem<GameData>>()
            {
                new MovementSystem(inputStorage)
            };
            return systems;
        }
    }
}