using System.Collections.Generic;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Tests
{
    public class ClientGameLogicFactory : IGameLogicSystemsFactory<GameData>
    {
        private readonly IPrefabProvider _prefabProvider;

        public ClientGameLogicFactory(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }
        public List<BaseSystem<GameData>> CreateLogic(IInputStorage<GameData> inputStorage)
        {
            var collectionUpdater = new CollectionUpdater<PhysicsObjectWrapper>();
            var scene = SceneManager.CreateScene("PhysicsScene"+Random.Range(0,999999), new CreateSceneParameters(LocalPhysicsMode.Physics3D));
            var systems = new List<BaseSystem<GameData>>()
            {
                new LevelInitializeSystem(scene, _prefabProvider),
                new InputSystem(inputStorage),
                new PhysicsBodyCreationSystem(_prefabProvider, collectionUpdater, scene),
                new PhysicsPrePositionSystem(collectionUpdater),
                new MovementSystem(collectionUpdater)
            };
            return systems;
        }
    }
}