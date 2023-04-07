using Common.Simulation;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public interface ISimulationFactory
    {
        TableSet CreateSimulation();

    }
}