using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class AvatarHealthSystem : BaseSystem<GameData>
    {
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var avatarCount = data.World.Avatar.Count;
            for (int i = 0; i < avatarCount; i++)
            {
                var id = data.World.Avatar.IdAt(i);
                var entity = data.World[id];
                if(entity.AvatarRespawn != null)
                    continue;
                var health = entity.Health;
                if (health.CurrentHealth <= 0)
                {
                    entity.Avatar.Destroyed = true;
                    var respawn = entity.AddAvatarRespawn();
                    respawn.RespawnTick = data.Tick + 15;
                    entity.DelPhysicsObject();
                }
            }
        }
    }
}