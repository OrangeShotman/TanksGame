using System.Collections.Generic;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame;
using OrangeShotStudio.TanksGame.View;
using UnityEngine.SceneManagement;

namespace Game.Tests
{
    public class ServerGameLogicFactory : IGameLogicSystemsFactory<GameData>
    {
        private readonly BaseSystem<GameData> _playerHandlerSystem;
        private readonly IPrefabProvider _prefabProvider;

        public ServerGameLogicFactory(BaseSystem<GameData> playerHandlerSystem, IPrefabProvider prefabProvider)
        {
            _playerHandlerSystem = playerHandlerSystem;
            _prefabProvider = prefabProvider;
        }
        
        public List<BaseSystem<GameData>> CreateLogic(IInputStorage<GameData> inputStorage)
        {
            var collectionUpdater = new CollectionUpdater<PhysicsObjectWrapper>();
            var scene = SceneManager.CreateScene("PhysicsScene", new CreateSceneParameters(LocalPhysicsMode.Physics3D));
        
            var systems = new List<BaseSystem<GameData>>()
            {
                new LevelInitializeSystem(scene, _prefabProvider),
                _playerHandlerSystem,
                new InputSystem(inputStorage),
                new PhysicsBodyCreationSystem(_prefabProvider, collectionUpdater, scene),
                new PhysicsPrePositionSystem(collectionUpdater),
                new MovementSystem(collectionUpdater)
            };
            return systems;
        }
    }
}