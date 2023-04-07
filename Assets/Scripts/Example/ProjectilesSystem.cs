using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ProjectilesSystem : SimulationBaseSystem
    {
        private PhysicsScene _physicsScene;
        private readonly RaycastHit[] _raycastHits = new RaycastHit[10];

        public ProjectilesSystem(TableSet simulation, Scene scene) : base(simulation)
        {
            _physicsScene = scene.GetPhysicsScene();
        }

        protected override void SimulationUpdate(GameData data, TimeData timeData)
        {
            var count = Simulation.Projectile.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                var id = Simulation.Projectile.IdAt(i);
                ProcessProjectile(data, Simulation[id]);
            }
        }

        private void ProcessProjectile(GameData data, Entity entity)
        {
            var projectile = entity.Projectile;
            if (projectile.DestroyTick > data.Tick)
            {
                var transform = entity.Transform;
                var movement = entity.Movement;
                var forward = new Vector3(transform.Forward.x, 0, transform.Forward.y);
                var hitsCount = _physicsScene.Raycast(transform.Position, forward, _raycastHits,
                    movement.Movement.magnitude, ~(1 << 10));
                for (int j = 0; j < hitsCount; j++)
                {
                    var hit = _raycastHits[j];
                    var physicsObjectBehaviour = hit.collider.GetComponent<PhysicsObjectBehaviour>();
                    if (physicsObjectBehaviour && physicsObjectBehaviour.EntityId == projectile.Source)
                        continue;
                    entity.AddRemoveEntityComponent();
                    transform.Position = hit.point;
                    DamageEntity(data, projectile, physicsObjectBehaviour);
                    break;
                }

                if (hitsCount == 0)
                    transform.Position += new Vector3(movement.Movement.x, 0, movement.Movement.y);
                return;
            }

            entity.AddRemoveEntityComponent();
        }

        private void DamageEntity(GameData gameData, Projectile projectile, PhysicsObjectBehaviour damaged)
        {
            if(!damaged)
                return;
            var damagedEntity = gameData.World[damaged.EntityId];
            if(damagedEntity == null)
                return;
            var damage = damagedEntity.AddDamage();
            damage.Value = projectile.Damage;
        }
    }
}