using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Avatar
    {
        public int OwnerUserId;
        public bool Destroyed;
    }
}