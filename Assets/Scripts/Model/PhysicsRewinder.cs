using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Network;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class PhysicsRewinder
    {
        private readonly PhysicsBodyCreationSystem _physicsBodyCreationSystem;
        private readonly PhysicsPrePositionSystem _prePositionSystem;
        private readonly History<GameData> _worldHistory;

        public PhysicsRewinder(PhysicsBodyCreationSystem physicsBodyCreationSystem,
            PhysicsPrePositionSystem prePositionSystem, History<GameData> worldHistory)
        {
            _physicsBodyCreationSystem = physicsBodyCreationSystem;
            _prePositionSystem = prePositionSystem;
            _worldHistory = worldHistory;
        }

        public bool TryRewind(int tick, TimeData currentTimeData)
        {
            var gameData = _worldHistory.Get(tick);
            if (gameData.Tick != tick)
                return false;
            _physicsBodyCreationSystem.Update(gameData, currentTimeData);
            _prePositionSystem.Update(gameData, currentTimeData);
            return true;
        }
        
        public void ReturnToCurrent(GameData gameData, TimeData currentTimeData)
        {
            _physicsBodyCreationSystem.Update(gameData, currentTimeData);
            _prePositionSystem.Update(gameData, currentTimeData);
        }

        public void Dispose()
        {
            foreach (var gameData in _worldHistory)
            {
                gameData.Dispose();
            }
        }
    }
}