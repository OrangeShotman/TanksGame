using OrangeShotStudio.Application;
using OrangeShotStudio.DB.Application;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Provider;
using OrangeShotStudio.Scripts.Tools;
using OrangeShotStudio.Structuries;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class ServerState : BaseGameState
    {
        private readonly IPrefabProvider _prefabProvider;
        private InputStorageFactory _inputStorageFactory;
        private ServerFacade<GameData> _serverFacade;

        public ServerState(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }
        public override void Initialize()
        {
            var logger = new UnityLogger();
            var inputPool = new Common.Input.TableSet.Pools();
            var worldPool = new Common.World.TableSet.Pools();
            var gameDataFactory = new GameDataFactory(inputPool, worldPool);
            _inputStorageFactory = new InputStorageFactory(gameDataFactory);
            var playerHandlerSystem = new PlayerHandlerSystem(logger);
            var settings = new GameServerSettings(3239, 5000, 10, 8, ConnectionType.WebSockets);
            _serverFacade = ServerFacadeFactory.CreateServer(gameDataFactory,
                new ServerGameLogicFactory(playerHandlerSystem, _prefabProvider),
                playerHandlerSystem, logger, settings);
        }

        public override void Update(TimeData timeData)
        {
            _serverFacade.Update();
        }

        public override void OnQuit()
        {
            _serverFacade.Dispose();
            _inputStorageFactory.Dispose();
        }
    }

    public partial class ServerTanksGameStateFactory
    {
        private readonly IPrefabProvider _prefabProvider;

        public ServerTanksGameStateFactory(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }

        public IGameState CreateServerState()
        {
            return new ServerState(_prefabProvider);
        }
    }
}