using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs.Input
{
    [EntityDeclaration("Input")]
    public class Entity
    {
        public PlayerInput PlayerInput;
    }
}

namespace OrangeShotStudio.Multiplayer.Ecs.World
{
    [EntityDeclaration("World")]
    public class Entity
    {
        [Predictable(0.1f)]
        public Transform Transform;
        [DontPack]
        public MovementComponent Movement;
        public PhysicsObject PhysicsObject;
        public Player Player;
        public Avatar Avatar;
        public Projectile Projectile;
        public Gun Gun;
    }
}