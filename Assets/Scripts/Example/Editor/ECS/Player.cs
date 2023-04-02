using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Player
    {
        public int UserId;
        public bool InputIsAcknowledged;
    }
}