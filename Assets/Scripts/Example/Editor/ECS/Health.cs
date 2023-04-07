using CodeGen.Attributes;

namespace OrangeShotStudio.Multiplayer.Ecs
{
    [Component]
    public class Health
    {
        public float CurrentHealth;
        public float MaxHealth;
    }
}