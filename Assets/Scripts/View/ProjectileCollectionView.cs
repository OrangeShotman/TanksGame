using Common;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.Multiplayer;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class ProjectileCollectionView : IUpdateImplementer<ProjectileView>
    {
        private readonly IPrefabProvider _prefabProvider;
        private readonly CollectionUpdater<ProjectileView> _collectionUpdater = new CollectionUpdater<ProjectileView>();
        private GameData _gameData;

        public ProjectileCollectionView(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }

        public void Update(GameData gameData)
        {
            _gameData = gameData;
            _collectionUpdater.ProcessUpdate(this);
        }

        public void Dispose()
        {
            _collectionUpdater.Dispose(this);
        }

        ITable IUpdateImplementer<ProjectileView>.GetTable()
        {
            return _gameData.World.Projectile;
        }

        CreationResult<ProjectileView> IUpdateImplementer<ProjectileView>.Factory(uint entityId, int entityIndex)
        {
            var prefab = _prefabProvider.GetPrefab("Projectile");
            var instance = Object.Instantiate(prefab);
            var transform = _gameData.World.Transform[entityId];
            var result = new ProjectileView(instance);
            result.Update(transform);
            return new CreationResult<ProjectileView>()
            {
                IsCreated = true,
                Result = result
            };
        }

        void IUpdateImplementer<ProjectileView>.Update(uint entityId, int entityIndex, ProjectileView viewElement)
        {
            var transform = _gameData.World.Transform[entityId];
            viewElement.Update(transform);
        }

        void IUpdateImplementer<ProjectileView>.Dispose(uint entityId, ProjectileView viewElement)
        {
            viewElement.Dispose();
        }

        bool IUpdateImplementer<ProjectileView>.HasEntityWithId(uint entityId, int entityIndex)
        {
            return true;
        }
    }
}