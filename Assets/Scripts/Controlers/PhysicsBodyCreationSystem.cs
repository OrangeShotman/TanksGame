using System.Collections.Generic;
using Common;
using Common.World;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OrangeShotStudio.TanksGame
{
    public class LevelInitializeSystem : BaseSystem<GameData>
    {
        private readonly IPrefabProvider _prefabProvider;
        private readonly Scene _scene;
        private GameObject _levelInstance;

        public LevelInitializeSystem(Scene scene, IPrefabProvider prefabProvider)
        {
            _scene = scene;
            _prefabProvider = prefabProvider;
        }

        public override void Initialize(GameData data, TimeData timeData)
        {
            var level = _prefabProvider.GetPrefab("Level");
            _levelInstance = Object.Instantiate(level);
            SceneManager.MoveGameObjectToScene(_levelInstance, _scene);
        }

        public override void Dispose()
        {
            Object.Destroy(_levelInstance);
            SceneManager.UnloadSceneAsync(_scene);
        }
    }
    public class PhysicsBodyCreationSystem : BaseSystem<GameData>, IUpdateImplementer<PhysicsObjectWrapper>
    {
        private readonly PhysicsScene _physicsScene;
        private readonly IPrefabProvider _prefabProvider;
        private readonly Scene _scene;
        private readonly CollectionUpdater<PhysicsObjectWrapper> _collectionUpdater;
        private GameData _gameData;

        public PhysicsBodyCreationSystem(IPrefabProvider prefabProvider,
            CollectionUpdater<PhysicsObjectWrapper> collectionUpdater, Scene scene)
        {
            _collectionUpdater = collectionUpdater;
            _prefabProvider = prefabProvider;
            _scene = scene;
            _physicsScene = scene.GetPhysicsScene();
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            _gameData = data;
            _collectionUpdater.ProcessUpdate(this);
        }


        public override void Dispose()
        {
            _collectionUpdater.Dispose(this);
        }

        public ITable GetTable()
        {
            return _gameData.World.PhysicsObject;
        }

        public CreationResult<PhysicsObjectWrapper> Factory(uint entityId, int entityIndex)
        {
            var entity = _gameData.World[entityId];
            var physicsObject = entity.PhysicsObject;
            var prefab = _prefabProvider.GetPrefab(physicsObject.BodyType.ToString());
            var transform = entity.Transform;
            var instance = Object.Instantiate(prefab);
            SceneManager.MoveGameObjectToScene(instance, _scene);
            instance.transform.position = transform.Position;
            if (transform.Forward != Vector2.zero)
                instance.transform.forward = transform.Forward;
            return new CreationResult<PhysicsObjectWrapper>()
            {
                IsCreated = true,
                Result = new PhysicsObjectWrapper(instance)
            };
        }

        public void Update(uint entityId, int entityIndex, PhysicsObjectWrapper viewElement)
        {
        }

        public void Dispose(uint entityId, PhysicsObjectWrapper viewElement)
        {
            viewElement.Dispose();
        }

        public bool HasEntityWithId(uint entityId, int entityIndex)
        {
            return _gameData.World.PhysicsObject.CmpAt(entityIndex) != null;
        }
    }
}