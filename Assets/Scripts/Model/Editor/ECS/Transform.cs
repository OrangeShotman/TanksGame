using CodeGen;
using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Transform
    {
        [LinearInterpolation]
        public Vector3 Position;
        [LinearInterpolation]
        public Vector2 Forward;
    }
}