using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class DamageSystem : BaseSystem<GameData>
    {
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.Damage.Count;
            for (int i = 0; i < count; i++)
            {
                var id = data.World.Damage.IdAt(i);
                var entity = data.World[id];
                var damage = entity.Damage;
                var health = entity.Health;
                if (health != null)
                {
                    health.CurrentHealth -= damage.Value;
                }
                entity.DelDamage();
            }
        }
    }
}