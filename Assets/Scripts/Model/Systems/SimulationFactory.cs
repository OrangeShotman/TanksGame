using Common.Simulation;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class SimulationFactory : ISimulationFactory
    {

        public TableSet CreateSimulation()
        {
            return new TableSet(new TableSet.Pools());
        }
    }
}