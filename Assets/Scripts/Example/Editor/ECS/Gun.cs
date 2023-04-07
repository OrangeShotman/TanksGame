using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Gun
    {
        public bool Use;
        public int ShotCount;
        public int NextShotTick;
        public int CooldownDuration;
        public float PositionOffset;
    }
}