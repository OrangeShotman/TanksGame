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
        private readonly int _userId;
        private ClientGameFacade<GameData> _gameClientFacade;
        private InputStorageFactory _inputStorageFactory;
        private InputProvider _inputProvider;
        private SimulationData _simulation;
        private IHudWindow _hudWindow;
        private GameplayView _gameplayView;

        public ClientGameplayState(IPrefabProvider prefabProvider, InterfaceView interfaceView, int userId)
        {
            _prefabProvider = prefabProvider;
            _interfaceView = interfaceView;
            _userId = userId;
        }

        public override void Initialize()
        {
            var inputPool = new Common.Input.TableSet.Pools();
            var worldPool = new Common.World.TableSet.Pools();
            var simulationPool = new Common.Simulation.TableSet.Pools();
            var gameDataFactory = new GameDataFactory(inputPool, worldPool);
            CreateGame(gameDataFactory, simulationPool);
            _hudWindow = _interfaceView.GetWindow<IHudWindow>();
            _inputProvider = new InputProvider(gameDataFactory, _hudWindow);
            if (UnityEngine.Application.isMobilePlatform)
                _hudWindow.Show();
            _gameplayView = new GameplayView(_hudWindow, _prefabProvider, gameDataFactory, simulationPool, _userId);
        }

        public override void Update(TimeData timeData)
        {
            var input = _inputProvider.GetInput(_gameplayView.CameraProjection,
                _gameplayView.LastRenderedServerTick);
            input.Tick = _gameClientFacade.CurrentSnapshot.Tick;
            _gameClientFacade.Update(input);
            _gameplayView.Update(_gameClientFacade.SnapshotsHistory, _gameClientFacade.CurrentSnapshot, _simulation);
        }

        public override void OnQuit()
        {
            _gameClientFacade.Dispose();
            _inputStorageFactory.Dispose();
            _inputProvider.Dispose();
            _gameplayView.Dispose();
            _simulation.Dispose();
        }

        private void CreateGame(GameDataFactory gameDataFactory, Common.Simulation.TableSet.Pools simulationPool)
        {
            _simulation = new SimulationData(new Common.Simulation.TableSet(simulationPool));
            var simulationProvider = new SimulationTableProvider(_simulation.Data);
            _inputStorageFactory = new InputStorageFactory(gameDataFactory);
            var settings = new GameClientSettings(
                _userId, "18.189.28.22", 3239, 5000, StaticSettings.ConnectionType, StaticSettings.UpdateType,
                StaticSettings.TickRate, StaticSettings.TickRateChange);
            _gameClientFacade = ClientFacadeFactory.CreateClient(settings, gameDataFactory,
                new ClientGameLogicFactory(simulationProvider, _prefabProvider, _userId),
                new MisPredictionChecker(_userId),
                _inputStorageFactory, new UnityLogger());
        }
    }

    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        public IGameState CreateGameplayState()
        {
            return new ClientGameplayState(PrefabProvider, InterfaceView, _userId);
        }
    }
}