using System.Linq;
using System.Text;
using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ProjectilesSystem : SimulationBaseSystem
    {
        private readonly PhysicsRewinder _physicsRewinder;
        private PhysicsScene _physicsScene;
        private readonly RaycastHit[] _raycastHits = new RaycastHit[10];

        public ProjectilesSystem(TableSet simulation, Scene scene, PhysicsRewinder physicsRewinder) :
            base(simulation)
        {
            _physicsRewinder = physicsRewinder;
            _physicsScene = scene.GetPhysicsScene();
        }

        protected override void SimulationUpdate(GameData data, TimeData timeData)
        {
            var count = Simulation.Projectile.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                var id = Simulation.Projectile.IdAt(i);
                ProcessProjectile(data, Simulation[id], timeData);
            }
        }

        public override void Dispose()
        {
            _physicsRewinder.Dispose();
        }

        private void ProcessProjectile(GameData data, Entity entity, TimeData timeData)
        {
            var projectile = entity.Projectile;
            if (projectile.DestroyTick > data.Tick)
            {
                //todo мнго кода - надо зарефачить
                var transform = entity.Transform;
                var movement = entity.Movement;
                var forward = new Vector3(transform.Forward.x, 0, transform.Forward.y);
                var rewindTo = data.Tick + projectile.ShotTickOffset;
                var rewinded = _physicsRewinder.TryRewind(rewindTo, timeData);
                if (!rewinded)
                {
                    _physicsRewinder.ReturnToCurrent(data, timeData);
                }

                var hitsCount = _physicsScene.SphereCast(transform.Position, 0.1f, forward, _raycastHits,
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
                    return;
                }


                transform.Position += new Vector3(movement.Movement.x, 0, movement.Movement.y);
                // _stringBuilder.Clear();
                // _stringBuilder.AppendLine($"rewindTo:{rewindTo}, current:{data.Tick}, projectilePos:{transform.Position} ");
                // foreach (var gameObject in _scene.GetRootGameObjects())
                // {
                //     var p = gameObject.GetComponent<PhysicsObjectBehaviour>();
                //     if (!p)
                //         continue;
                //     _stringBuilder.AppendLine($"id:{p.EntityId}, pos:{p.transform.position} ");
                // }
                //
                // Debug.Log(_stringBuilder.ToString());

                return;
            }

            entity.AddRemoveEntityComponent();
        }

        private void DamageEntity(GameData gameData, Projectile projectile, PhysicsObjectBehaviour damaged)
        {
            if (!damaged)
                return;
            var damagedEntity = gameData.World[damaged.EntityId];
            if (damagedEntity == null)
                return;
            var damage = damagedEntity.AddDamage();
            damage.Value = projectile.Damage;
        }
    }
}