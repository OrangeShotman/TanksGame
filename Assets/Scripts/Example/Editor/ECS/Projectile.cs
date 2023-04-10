using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Projectile
    {
        public uint Source;
        public int DestroyTick;
        public float Speed;
        public float Damage;
        public int ShotTickOffset;
    }
}