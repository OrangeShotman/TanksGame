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

        ITable IUpdateImplementer<PhysicsObjectWrapper>.GetTable()
        {
            return _gameData.World.PhysicsObject;
        }

        CreationResult<PhysicsObjectWrapper> IUpdateImplementer<PhysicsObjectWrapper>.Factory(uint entityId, int entityIndex)
        {
            var entity = _gameData.World[entityId];
            var physicsObject = entity.PhysicsObject;
            var prefab = _prefabProvider.GetPrefab(physicsObject.BodyType.ToString());
            var transform = entity.Transform;
            var instance = Object.Instantiate(prefab);
            SceneManager.MoveGameObjectToScene(instance, _scene);
            instance.transform.position = transform.Position;
            return new CreationResult<PhysicsObjectWrapper>()
            {
                IsCreated = true,
                Result = new PhysicsObjectWrapper(instance, entityId)
            };
        }

        void IUpdateImplementer<PhysicsObjectWrapper>.Update(uint entityId, int entityIndex, PhysicsObjectWrapper shotCounter)
        {
        }

        void IUpdateImplementer<PhysicsObjectWrapper>.Dispose(uint entityId, PhysicsObjectWrapper viewElement)
        {
            viewElement.Dispose();
        }

        bool IUpdateImplementer<PhysicsObjectWrapper>.HasEntityWithId(uint entityId, int entityIndex)
        {
            return _gameData.World.PhysicsObject.CmpAt(entityIndex) != null;
        }
    }
}