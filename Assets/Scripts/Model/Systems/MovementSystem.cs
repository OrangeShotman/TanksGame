using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class MovementSystem : BaseSystem<GameData>
    {
        private readonly CollectionUpdater<PhysicsObjectWrapper> _physicsObjects;

        public MovementSystem(CollectionUpdater<PhysicsObjectWrapper> physicsObjects)
        {
            _physicsObjects = physicsObjects;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.Movement.Count;
            for (int i = 0; i < count; i++)
            {
                var movementComponent = data.World.Movement.CmpAt(i);
                var id = data.World.Movement.IdAt(i);
                var entity = data.World[id];
                var transform = entity.Transform;
                var movement = movementComponent.Movement;
                if (movement != Vector2.zero)
                    transform.Forward = movement.normalized;
                var physicsObjectWrapper = _physicsObjects.GetById(id);
                if (physicsObjectWrapper != null)
                    transform.Position = physicsObjectWrapper.Move(new Vector3(movement.x, 0, movement.y));
                else
                    transform.Position += new Vector3(movement.x, 0, movement.y);
            }
        }
    }
}