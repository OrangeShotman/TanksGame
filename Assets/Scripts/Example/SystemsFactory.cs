using System.Collections.Generic;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class SystemsFactory
    {
        private readonly ISimulationFactory _simulationFactory;
        private readonly IPrefabProvider _prefabProvider;
        private readonly BaseSystem<GameData> _playerHandlerSystem;
        private readonly int _userId;

        public SystemsFactory(ISimulationFactory simulationFactory, IPrefabProvider prefabProvider,
            BaseSystem<GameData> playerHandlerSystem, int userId)
        {
            _simulationFactory = simulationFactory;
            _prefabProvider = prefabProvider;
            _playerHandlerSystem = playerHandlerSystem;
            _userId = userId;
        }

        public List<BaseSystem<GameData>> CreateSystems(IInputStorage<GameData> inputStorage, bool isServer)
        {
            var simulation = _simulationFactory.CreateSimulation();
            var collectionUpdater = new CollectionUpdater<PhysicsObjectWrapper>();
            var scene = SceneManager.CreateScene($"{(isServer ? "Server" : "Client")}-{Random.Range(0, 999999)}",
                new CreateSceneParameters(LocalPhysicsMode.Physics3D));

            var systems = new List<BaseSystem<GameData>>();
            systems.Add(new EntityClearSystem(simulation));
            systems.Add(new LevelInitializeSystem(scene, _prefabProvider));
            if (isServer)
                systems.Add(_playerHandlerSystem);
            systems.Add(new InputSystem(inputStorage));
            systems.Add(new PhysicsBodyCreationSystem(_prefabProvider, collectionUpdater, scene));
            systems.Add(new PhysicsPrePositionSystem(scene, collectionUpdater));
            systems.Add(new GunSystem());
            systems.Add(new ProjectilesSystem(simulation, scene));
            systems.Add(new MovementSystem(collectionUpdater));
            systems.Add(new ProjectileSpawnSystem(simulation));
            if (isServer)
            {
                systems.Add(new DamageSystem());
                systems.Add(new AvatarHealthSystem());
                systems.Add(new AvatarRespawnSystem());
            }
            if (!isServer)
                systems.Add(new PredictionStoreSystem(_userId));

            return systems;
        }
    }
}