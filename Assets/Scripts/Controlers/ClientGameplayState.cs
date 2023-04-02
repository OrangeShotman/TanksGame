using Game.Tests;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.Application;
using OrangeShotStudio.DB.Application;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Scripts.Tools;
using OrangeShotStudio.Structuries;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class ClientGameplayState : BaseGameState
    {
        private readonly InterfaceView _interfaceView;
        private readonly ClientTanksGameStateFactory _factory;
        private readonly int _userId;
        private ClientGameFacade<GameData> _gameClientFacade;
        private InputStorageFactory _inputStorageFactory;
        private GameData _input;

        public ClientGameplayState(InterfaceView interfaceView, ClientTanksGameStateFactory factory, int userId)
        {
            _interfaceView = interfaceView;
            _factory = factory;
            _userId = userId;
        }

        public override void Initialize()
        {
            var inputPool = new Common.Input.TableSet.Pools();
            var worldPool = new Common.World.TableSet.Pools();
            var gameSnapshotFactory = new GameDataFactory(inputPool, worldPool);
            _input = gameSnapshotFactory.CreateMessage();
            _inputStorageFactory = new InputStorageFactory(gameSnapshotFactory);
            var settings = new GameClientSettings(
                _userId, "127.0.0.1", 3239, 5000, ConnectionType.Pixockets,
                GameClientSettings.GameClientUpdateType.InThread, 20, 5);
            _gameClientFacade = ClientFacadeFactory.CreateClient(settings, gameSnapshotFactory,
                new ClientGameLogicFactory(), new MisPredictionChecker(_userId),_inputStorageFactory, new UnityLogger());
            
        }

        public override void Update(TimeData timeData)
        {
            _gameClientFacade.Update(_input);
        }

        public override void OnQuit()
        {
            _inputStorageFactory.Dispose();
            _input.Input.Clear();
        }
    }

    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        public IGameState CreateGameplayState()
        {
            return new ClientGameplayState(InterfaceView, this, _userId);
        }
    }
}