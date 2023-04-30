using System.Collections.Generic;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Network;
using OrangeShotStudio.Provider;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ClientGameLogicFactory : IGameLogicSystemsFactory<GameData>
    {
        private readonly SystemsFactory _systemsFactory;

        public ClientGameLogicFactory(ISimulationFactory simulationFactory, IPrefabProvider prefabProvider, int userId)
        {
            _systemsFactory = new SystemsFactory(simulationFactory, prefabProvider, null, userId);
        }

        public List<BaseSystem<GameData>> CreateLogic(IInputStorage<GameData> inputStorage, History<GameData> history)
        {
            return _systemsFactory.CreateSystems(inputStorage, history, false);
        }
    }
}