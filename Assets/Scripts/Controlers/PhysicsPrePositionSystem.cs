using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public class PhysicsPrePositionSystem : BaseSystem<GameData>
    {
        private readonly CollectionUpdater<PhysicsObjectWrapper> _collectionUpdater;

        public PhysicsPrePositionSystem(CollectionUpdater<PhysicsObjectWrapper> collectionUpdater)
        {
            _collectionUpdater = collectionUpdater;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.PhysicsObject.Count;
            for (int i = 0; i < count; i++)
            {
                var id = data.World.PhysicsObject.IdAt(i);
                var physicsObjectWrapper = _collectionUpdater.GetById(id);
                var transform = data.World.Transform[id];
                physicsObjectWrapper.SetPosition(transform);
            }
            Physics.SyncTransforms();
        }
    }
}