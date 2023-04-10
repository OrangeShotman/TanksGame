using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.Application;
using OrangeShotStudio.DB.Application;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Provider;
using OrangeShotStudio.Scripts.Tools;
using OrangeShotStudio.Structuries;
using OrangeShotStudio.TanksGame.View;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class ClientGameplayState : BaseGameState
    {
        private readonly IPrefabProvider _prefabProvider;
        private readonly InterfaceView _interfaceView;
        private readonly ClientTanksGameStateFactory _factory;
        private readonly int _userId;
        private readonly TankCollectionView _tankCollectionView;
        private ClientGameFacade<GameData> _gameClientFacade;
        private InputStorageFactory _inputStorageFactory;
        private InputProvider _inputProvider;
        private ClientInterpolator _clientInterpolator;
        private ProjectileCollectionView _projectileCollectionView;
        private SimulationData _simulation;

        public ClientGameplayState(IPrefabProvider prefabProvider, InterfaceView interfaceView,
            ClientTanksGameStateFactory factory, int userId)
        {
            _tankCollectionView = new TankCollectionView(prefabProvider, userId);
            _projectileCollectionView = new ProjectileCollectionView(prefabProvider);
            _prefabProvider = prefabProvider;
            _interfaceView = interfaceView;
            _factory = factory;
            _userId = userId;
        }

        public override void Initialize()
        {
            var inputPool = new Common.Input.TableSet.Pools();
            var worldPool = new Common.World.TableSet.Pools();
            var simulationPool = new Common.Simulation.TableSet.Pools();
            _simulation = new SimulationData(new Common.Simulation.TableSet(simulationPool));
            var simulationProvider = new InjectedSimulationProvider(_simulation.Data);
            var gameDataFactory = new GameDataFactory(inputPool, worldPool);
            _inputStorageFactory = new InputStorageFactory(gameDataFactory);
            var settings = new GameClientSettings(
                _userId, "127.0.0.1", 3239, 5000, ConnectionType.WebSockets,
                GameClientSettings.GameClientUpdateType.InCoroutine, 10, 3);
            _gameClientFacade = ClientFacadeFactory.CreateClient(settings, gameDataFactory,
                new ClientGameLogicFactory(simulationProvider, _prefabProvider, gameDataFactory, _userId),
                new MisPredictionChecker(_userId),
                _inputStorageFactory, new UnityLogger());
            _inputProvider = new InputProvider(gameDataFactory);
            _clientInterpolator = new ClientInterpolator(gameDataFactory, simulationPool);
        }

        public override void Update(TimeData timeData)
        {
            var input = _inputProvider.GetInput(_tankCollectionView.CameraProjection,
                _gameClientFacade.CurrentSnapshot.ServerTick);
            input.Tick = _gameClientFacade.CurrentSnapshot.Tick;
            _gameClientFacade.Update(input);
            var interpolated = _clientInterpolator.Interpolate(_gameClientFacade.CurrentSnapshot, _simulation);
            _tankCollectionView.Update(interpolated.GameData);
            _projectileCollectionView.Update(interpolated.SimulationData.Data);
        }

        public override void OnQuit()
        {
            _gameClientFacade.Dispose();
            _inputStorageFactory.Dispose();
            _inputProvider.Dispose();
            _tankCollectionView.Dispose();
            _clientInterpolator.Dispose();
            _projectileCollectionView.Dispose();
            _simulation.Dispose();
        }
    }

    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        public IGameState CreateGameplayState()
        {
            return new ClientGameplayState(PrefabProvider, InterfaceView, this, _userId);
        }
    }
}