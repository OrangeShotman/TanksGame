using Common.Simulation;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public abstract class SimulationBaseSystem : BaseSystem<GameData>
    {
        protected readonly TableSet Simulation;
        private int _lastTickUpdate;

        protected SimulationBaseSystem(TableSet simulation)
        {
            Simulation = simulation;
        }

        protected sealed override void InternalUpdate(GameData data, TimeData timeData)
        {
            if (_lastTickUpdate >= data.Tick)
                return;
            _lastTickUpdate = data.Tick;
            SimulationUpdate(data, timeData);
        }

        protected abstract void SimulationUpdate(GameData data, TimeData timeData);
    }
}