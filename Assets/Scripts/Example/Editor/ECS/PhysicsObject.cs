using CodeGen;
using CodeGen.Attributes;
using Common.World;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class PhysicsObject
    {
        public Vector3 Size;
        public PhysicsBodyType BodyType;
    }
}