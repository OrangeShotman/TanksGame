using Common.Simulation;
using OrangeShotStudio.Network;
using OrangeShotStudio.TanksGame.Multiplayer;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public class ClientInterpolator
    {
        private InterpolatorByHistory<GameData> _interpolator;
        private InterpolatorByHistory<GameData> _interpolatorOfOtherWorld;
        private Interpolator<SimulationData> _simulationInterpolator;

        public ClientInterpolator(GameDataFactory gameDataFactory, TableSet.Pools pools)
        {
            var gameDataInterpolationStrategy = new GameDataInterpolationStrategy();
            _interpolator = new InterpolatorByHistory<GameData>(
                gameDataFactory.CreateMessage(),
                new PredictedTargetFrameCalculator(),
                gameDataInterpolationStrategy,
                new GameDataCopier(),
                StaticSettings.TickDurationMs * 0.001f,
                StaticSettings.FastTickDurationMs * 0.001f,
                StaticSettings.TickRateChange);
            _interpolatorOfOtherWorld = new InterpolatorByHistory<GameData>(
                gameDataFactory.CreateMessage(),
                new ServerTargetFrameCalculator(),
                gameDataInterpolationStrategy,
                new GameDataCopier(),
                StaticSettings.TickDurationMs * 0.001f,
                StaticSettings.FastTickDurationMs * 0.001f,
                StaticSettings.TickRateChange);
            _simulationInterpolator = new Interpolator<SimulationData>(
                new SimulationData(new TableSet(pools)),
                new SimulationData(new TableSet(pools)),
                new SimulationData(new TableSet(pools)),
                new SimulationInterpolationStrategy());
        }

        public InterpolationResult Interpolate(History<GameData> history, GameData gameData,
            SimulationData simulationData)
        {
            // return new InterpolationResult()
            // {
            //     GameData = gameData,
            //     SimulationData = simulationData
            // };
            _simulationInterpolator.UpdateNextState(simulationData, gameData.Tick);
            var interpolatedData = _interpolator.GetInterpolatedSnapshot(history, Time.time);
            var otherWorldInterpolation = _interpolatorOfOtherWorld.GetInterpolatedSnapshot(history, Time.time);
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
            _simulationInterpolator.Dispose();
        }

        public struct InterpolationResult
        {
            public GameData GameData;
            public SimulationData SimulationData;
        }
    }
}