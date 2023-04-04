using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class MovementSystem : BaseSystem<GameData>
    {
        private readonly CollectionUpdater<PhysicsObjectWrapper> _collectionUpdater;

        public MovementSystem(CollectionUpdater<PhysicsObjectWrapper> collectionUpdater)
        {
            _collectionUpdater = collectionUpdater;
        }
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.Movement.Count;
            for (int i = 0; i < count; i++)
            {
                var motionComponent = data.World.Movement.CmpAt(i);
                var id = data.World.Movement.IdAt(i);
                var avatarEntity = data.World[id];
                var transform = avatarEntity.Transform;
                var movement = motionComponent.Movement;
                if (movement != Vector2.zero)
                    movement = movement.normalized;
                var motion = movement.normalized * 5 *
                             (float)timeData.DeltaTimeMs * 0.001f;
                if (movement != Vector2.zero)
                    transform.Forward = movement;
                var physicsObjectWrapper = _collectionUpdater.GetById(id);
                transform.Position = physicsObjectWrapper.Move(new Vector3(motion.x, 0, motion.y));
                var transformPredicted = avatarEntity.AddTransformPredicted();
                data.World.CopyTransformPredicted(transformPredicted, transform);
            }
        }
    }
}