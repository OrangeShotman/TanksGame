using Common.Simulation;
using OrangeShotStudio.Network;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class ClientInterpolator
    {
        private Interpolator<GameData> _interpolator;
        private Interpolator<GameData> _interpolatorOfOtherWorld;
        private Interpolator<SimulationData> _simulationInterpolator;

        public ClientInterpolator(GameDataFactory gameDataFactory, Common.Simulation.TableSet.Pools pools)
        {
            var gameDataInterpolationStrategy = new GameDataInterpolationStrategy();
            _interpolator = new Interpolator<GameData>(
                gameDataFactory.CreateMessage(),
                gameDataFactory.CreateMessage(),
                gameDataFactory.CreateMessage(),
                gameDataInterpolationStrategy);
            _interpolatorOfOtherWorld = new Interpolator<GameData>(
                gameDataFactory.CreateMessage(),
                gameDataFactory.CreateMessage(),
                gameDataFactory.CreateMessage(), 
                gameDataInterpolationStrategy);
            _simulationInterpolator = new Interpolator<SimulationData>(
                new SimulationData(new TableSet(pools)),
                new SimulationData(new TableSet(pools)),
                new SimulationData(new TableSet(pools)),
                    new SimulationInterpolationStrategy());
        }

        public InterpolationResult Interpolate(GameData gameData, SimulationData simulationData)
        {
            _interpolator.UpdateNextState(gameData, gameData.Tick);
            _interpolatorOfOtherWorld.UpdateNextState(gameData, gameData.ServerTick);
            _simulationInterpolator.UpdateNextState(simulationData, gameData.Tick);
            var interpolatedData = _interpolator.Interpolate();
            var otherWorldInterpolation = _interpolatorOfOtherWorld.Interpolate();
            otherWorldInterpolation.MergeWithPredicted(interpolatedData);
            var interpolatedSimulation = _simulationInterpolator.Interpolate();
            return new InterpolationResult()
            {
                GameData = interpolatedData,
                SimulationData = interpolatedSimulation
            };
        }

        public void Dispose()
        {
            _interpolator.Dispose();
            _interpolatorOfOtherWorld.Dispose();
            _simulationInterpolator.Dispose();
        }
        
        public struct InterpolationResult
        {
            public GameData GameData;
            public SimulationData SimulationData;
        }
    }
}