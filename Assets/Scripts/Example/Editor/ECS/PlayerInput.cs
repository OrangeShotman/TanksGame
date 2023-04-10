using CodeGen;
using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class PlayerInput
    {
        public Vector2 Movement;
        public bool Shot;
        public int OtherWorldTick;
    }
}