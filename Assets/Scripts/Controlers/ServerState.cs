using Game.Tests;
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
        private InputStorageFactory _inputStorageFactory;
        private ServerFacade<GameData> _serverFacade;

        public override void Initialize()
        {
            var logger = new UnityLogger();
            var inputPool = new Common.Input.TableSet.Pools();
            var worldPool = new Common.World.TableSet.Pools();
            var gameSnapshotFactory = new GameDataFactory(inputPool, worldPool);
            _inputStorageFactory = new InputStorageFactory(gameSnapshotFactory);
            var playerHandlerSystem = new PlayerHandlerSystem(logger);
            var settings = new GameServerSettings(3239, 5000, 20, 5, ConnectionType.Pixockets);
            _serverFacade = ServerFacadeFactory.CreateServer(gameSnapshotFactory,
                new ServerGameLogicFactory(playerHandlerSystem),
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
            return new ServerState();
        }
    }
}