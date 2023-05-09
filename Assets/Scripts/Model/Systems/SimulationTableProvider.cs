using Common.Simulation;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class SimulationTableProvider : ISimulationFactory
    {
        private readonly TableSet _simulation;

        public SimulationTableProvider(TableSet simulation)
        {
            _simulation = simulation;
        }
        public TableSet CreateSimulation()
        {
            return _simulation;
        }
    }
}