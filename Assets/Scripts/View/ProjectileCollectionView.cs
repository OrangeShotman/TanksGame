using Common;
using OrangeShotStudio.Provider;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class ProjectileCollectionView : IUpdateImplementer<ProjectileView>
    {
        private readonly IPrefabProvider _prefabProvider;
        private readonly CollectionUpdater<ProjectileView> _collectionUpdater = new CollectionUpdater<ProjectileView>();
        private Common.Simulation.TableSet _simulation;

        public ProjectileCollectionView(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }

        public void Update(Common.Simulation.TableSet simulation)
        {
            _simulation = simulation;
            _collectionUpdater.ProcessUpdate(this);
        }

        public void Dispose()
        {
            _collectionUpdater.Dispose(this);
        }

        ITable IUpdateImplementer<ProjectileView>.GetTable()
        {
            return _simulation.Projectile;
        }

        CreationResult<ProjectileView> IUpdateImplementer<ProjectileView>.Factory(uint entityId, int entityIndex)
        {
            var prefab = _prefabProvider.GetPrefab("Projectile");
            var instance = Object.Instantiate(prefab);
            var transform = _simulation.Transform[entityId];
            var result = new ProjectileView(instance);
            result.Update(transform);
            return new CreationResult<ProjectileView>()
            {
                IsCreated = true,
                Result = result
            };
        }

        void IUpdateImplementer<ProjectileView>.Update(uint entityId, int entityIndex, ProjectileView shotCounter)
        {
            var transform = _simulation.Transform[entityId];
            shotCounter.Update(transform);
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