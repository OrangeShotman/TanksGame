using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GunSystem : BaseSystem<GameData>
    {
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.Gun.Count;
            for (int i = 0; i < count; i++)
            {
                var gun = data.World.Gun.CmpAt(i);
                if (gun.Use && gun.NextShotTick <= data.Tick)
                {
                    gun.ShotCount++;
                    gun.NextShotTick = data.Tick + gun.CooldownDuration;
                    CreateProjectile(data,  data.World.Gun.IdAt(i), timeData);
                }
                gun.Use = false;
            }
        }

        private void CreateProjectile(GameData gameData, uint sourceId, TimeData timeData)
        {
            var sourceEntity = gameData.World[sourceId];
            var entity = gameData.World.CreateEntity();
            var transform = entity.AddTransform();
            var movement = entity.AddMovement();
            var projectile = entity.AddProjectile();
            transform.Position = sourceEntity.Transform.Position;
            transform.Forward = sourceEntity.Transform.Forward;
            projectile.Speed = 20;
            projectile.DestroyTick = gameData.Tick + 10 * 2;
            movement.Movement = transform.Forward * projectile.Speed * (float)(timeData.DeltaTimeMs / 1000);
        }
    }
}