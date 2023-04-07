using System.Collections.Generic;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Provider;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ServerGameLogicFactory : IGameLogicSystemsFactory<GameData>
    {
        private SystemsFactory _systemsFactory;

        public ServerGameLogicFactory(BaseSystem<GameData> playerHandlerSystem, IPrefabProvider prefabProvider)
        {
            var simulationFactory = new SimulationFactory();
            _systemsFactory = new SystemsFactory(simulationFactory, prefabProvider, playerHandlerSystem, 0);
        }

        public List<BaseSystem<GameData>> CreateLogic(IInputStorage<GameData> inputStorage)
        {
            return _systemsFactory.CreateSystems(inputStorage, true);
        }
    }
}