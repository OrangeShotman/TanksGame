using Common;
using Common.World;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;
using TableSet = Common.Simulation.TableSet;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ProjectileSpawnSystem : SimulationBaseSystem, IUpdateImplementer<ShotCounter>
    {
        private GameData _data;
        private CollectionUpdater<ShotCounter> _collectionUpdater = new CollectionUpdater<ShotCounter>();
        private TimeData _timeData;
        private int _lastTickUpdate;

        public ProjectileSpawnSystem(TableSet simulation) : base(simulation)
        {
        }

        protected override void SimulationUpdate(GameData data, TimeData timeData)
        {
            _timeData = timeData;
            _data = data;
            _collectionUpdater.ProcessUpdate(this);
        }

        private void CreateProjectile(GameData gameData, Gun gun, uint sourceId, TimeData timeData)
        {
            var sourceEntity = gameData.World[sourceId];
            var entity = Simulation.CreateEntity();
            var transform = entity.AddTransform();
            var movement = entity.AddMovement();
            var projectile = entity.AddProjectile();
            transform.Position = sourceEntity.Transform.Position + Vector3.up * gun.PositionOffset;
            transform.Forward = sourceEntity.Transform.Forward;
            projectile.Speed = 20;
            projectile.DestroyTick = gameData.Tick + 10 * 2;
            projectile.Damage = 35;
            projectile.Source = sourceEntity.Id;
            movement.Movement = transform.Forward * projectile.Speed * (float)(timeData.DeltaTimeMs / 1000);
        }

        ITable IUpdateImplementer<ShotCounter>.GetTable()
        {
            return _data.World.Gun;
        }

        CreationResult<ShotCounter> IUpdateImplementer<ShotCounter>.Factory(uint entityId, int entityIndex)
        {
            var gun = _data.World.Gun.CmpAt(entityIndex);
            return new CreationResult<ShotCounter>()
            {
                IsCreated = true,
                Result = new ShotCounter() { Count = gun.ShotCount }
            };
        }

        void IUpdateImplementer<ShotCounter>.Update(uint entityId, int entityIndex, ShotCounter shotCounter)
        {
            var gun = _data.World.Gun.CmpAt(entityIndex);
            if (shotCounter.Count < gun.ShotCount)
            {
                CreateProjectile(_data, gun, entityId, _timeData);
                shotCounter.Count++;
            }
        }

        void IUpdateImplementer<ShotCounter>.Dispose(uint entityId, ShotCounter viewElement)
        {
        }

        bool IUpdateImplementer<ShotCounter>.HasEntityWithId(uint entityId, int entityIndex)
        {
            return true;
        }
    }
}