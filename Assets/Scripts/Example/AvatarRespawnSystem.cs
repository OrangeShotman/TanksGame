using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class AvatarRespawnSystem : BaseSystem<GameData>
    {
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var respawnCount = data.World.AvatarRespawn.Count;
            for (int i = respawnCount - 1; i >= 0; i--)
            {
                var respawn = data.World.AvatarRespawn.CmpAt(i);
                if (respawn.RespawnTick <= data.Tick)
                {
                    var id = data.World.AvatarRespawn.IdAt(i);
                    var entity = data.World[id];
                    var health = entity.Health;
                    health.CurrentHealth = health.MaxHealth;
                    entity.Avatar.Destroyed = false;
                    entity.DelAvatarRespawn();
                    var transform = entity.Transform;
                    var position = Random.insideUnitCircle.normalized * 22;
                    transform.Position = new Vector3(position.x, 0, position.y);
                    transform.Forward = Random.insideUnitCircle.normalized;
                }
            }
        }
    }
}