using OrangeShotStudio.Network;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public interface ITargetFrameCalculator<T>
    {
        int GetTargetBaseState(History<T> history);
    }

    public class PredictedTargetFrameCalculator : ITargetFrameCalculator<GameData>
    {
        public int GetTargetBaseState(History<GameData> history)
        {
            return history.LastTick - 1;
        }
    }
    
    public class ServerTargetFrameCalculator : ITargetFrameCalculator<GameData>
    {
        public int GetTargetBaseState(History<GameData> history)
        {
            return history.Get(history.LastTick).ServerTick - 1;
        }
    }
}