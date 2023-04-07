using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class EntityClearSystem : SimulationBaseSystem
    {
        public EntityClearSystem(TableSet simulation) : base(simulation)
        {
        }

        protected override void SimulationUpdate(GameData data, TimeData timeData)
        {
            bool clearEntity = false;
            var count = Simulation.RemoveEntityComponent.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                var id = Simulation.RemoveEntityComponent.IdAt(i);
                Simulation[id].DeleteAll();
                clearEntity = true;
            }
            if(clearEntity)
                Simulation.DeleteEmptyEntities();
        }
    }
}