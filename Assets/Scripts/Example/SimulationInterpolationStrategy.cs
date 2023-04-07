namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class SimulationInterpolationStrategy : IInterpolationStrategy<SimulationData>
    {
        public void Interpolate(SimulationData result, SimulationData baseData, SimulationData nextData, float normalizedValue)
        {
            result.Data.Interpolate(baseData.Data, nextData.Data, normalizedValue);
        }
    }
}