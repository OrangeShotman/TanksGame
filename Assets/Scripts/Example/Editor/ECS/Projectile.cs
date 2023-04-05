using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Projectile
    {
        public int DestroyTick;
        public float Speed;
    }
}