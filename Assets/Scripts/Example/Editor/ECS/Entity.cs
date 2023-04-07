using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs.Simulation
{
    [EntityDeclaration("Simulation")]
    public class Entity
    {
        public Transform Transform;
        public MovementComponent Movement;
        public Projectile Projectile;
    }
}

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
        [Predictable(0.1f)]
        public Gun Gun;
    }
}