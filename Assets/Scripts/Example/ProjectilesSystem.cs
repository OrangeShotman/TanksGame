using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using Unity.VisualScripting.Antlr3.Runtime;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ProjectilesSystem : BaseSystem<GameData>
    {
        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var clearEmptyEntities = false;
            var count = data.World.Projectile.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                var projectile = data.World.Projectile.CmpAt(i);
                if (projectile.DestroyTick > data.Tick)
                    continue;
                var id = data.World.Projectile.IdAt(i);
                data.World[id].DeleteAll();
                clearEmptyEntities = true;
            }
            if(clearEmptyEntities)
                data.World.DeleteEmptyEntities();
        }
    }
}