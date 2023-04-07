using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;

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
                }

                gun.Use = false;
            }
        }
    }
}