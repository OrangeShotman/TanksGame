using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Network;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class HistoryRecorderSystem : BaseSystem<GameData>
    {
        private readonly History<GameData> _worldHistory;

        public HistoryRecorderSystem(History<GameData> history)
        {
            _worldHistory = history;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var historyData = _worldHistory.Get(data.Tick);
            data.CopyTo(historyData);
            _worldHistory.Put(historyData, data.Tick);
        }
    }
}