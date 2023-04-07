using Common;
using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.TanksGame.View;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ProjectileSpawnSystem : BaseSystem<GameData>, IUpdateImplementer<ShotCounter>
    {
        private readonly TableSet _simulation;
        private GameData _data;
        private CollectionUpdater<ShotCounter> _collectionUpdater = new CollectionUpdater<ShotCounter>();
        private TimeData _timeData;

        public ProjectileSpawnSystem(Common.Simulation.TableSet simulation)
        {
            _simulation = simulation;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            _timeData = timeData;
            _data = data;
            _collectionUpdater.ProcessUpdate(this);
        }

        private void CreateProjectile(GameData gameData, uint sourceId, TimeData timeData)
        {
            var sourceEntity = gameData.World[sourceId];
            var entity = _simulation.CreateEntity();
            var transform = entity.AddTransform();
            var movement = entity.AddMovement();
            var projectile = entity.AddProjectile();
            transform.Position = sourceEntity.Transform.Position;
            transform.Forward = sourceEntity.Transform.Forward;
            projectile.Speed = 20;
            projectile.DestroyTick = gameData.Tick + 10 * 2;
            movement.Movement = transform.Forward * projectile.Speed * (float)(timeData.DeltaTimeMs / 1000);
        }

        public ITable GetTable()
        {
            return _data.World.Gun;
        }

        public CreationResult<ShotCounter> Factory(uint entityId, int entityIndex)
        {
            var gun = _data.World.Gun.CmpAt(entityIndex);
            return new CreationResult<ShotCounter>()
            {
                IsCreated = true,
                Result = new ShotCounter(){Count = gun.ShotCount}
            };
        }

        public void Update(uint entityId, int entityIndex, ShotCounter shotCounter)
        {
            var gun = _data.World.Gun.CmpAt(entityIndex);
            if (shotCounter.Count < gun.ShotCount)
            {
                CreateProjectile(_data, entityId, _timeData);
                shotCounter.Count++;
            }
        }

        public void Dispose(uint entityId, ShotCounter viewElement)
        {
            
        }

        public bool HasEntityWithId(uint entityId, int entityIndex)
        {
            return true;
        }
    }
}