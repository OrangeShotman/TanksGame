using OrangeShotStudio.Network;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class ClientInterpolator
    {
        private  Interpolator _interpolator;
        private Interpolator _interpolatorOfOtherWorld;

        public ClientInterpolator(GameDataFactory gameDataFactory)
        {
            _interpolator = new Interpolator(gameDataFactory);
            _interpolatorOfOtherWorld = new Interpolator(gameDataFactory);
        }

        public GameData Interpolate(GameData gameData)
        {
            _interpolator.UpdateNextState(gameData, gameData.Tick);
            _interpolatorOfOtherWorld.UpdateNextState(gameData, gameData.ServerTick);
            var interpolatedData = _interpolator.Interpolate();
            var otherWorldInterpolation = _interpolatorOfOtherWorld.Interpolate();
            otherWorldInterpolation.MergeWithPredicted(interpolatedData);
            return interpolatedData;
        }

        public void Dispose()
        {
            _interpolator.Dispose();
            _interpolatorOfOtherWorld.Dispose();
        }
    }
}