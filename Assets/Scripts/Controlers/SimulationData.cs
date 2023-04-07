using Common.Simulation;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class SimulationData : IInterpolatable<SimulationData>
    {
        public readonly TableSet Data;

        public SimulationData(TableSet data)
        {
            Data = data;
        }
        public void CopyTo(SimulationData dst)
        {
            dst.Data.Copy(Data);
        }

        public void Dispose()
        {
            Data.Clear();
        }
    }
}