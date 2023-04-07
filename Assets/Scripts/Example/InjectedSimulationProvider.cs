using Common.Simulation;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class InjectedSimulationProvider : ISimulationFactory
    {
        private readonly TableSet _simulation;

        public InjectedSimulationProvider(TableSet simulation)
        {
            _simulation = simulation;
        }
        public TableSet CreateSimulation()
        {
            return _simulation;
        }
    }
}