using OrangeShotStudio.Analytics;
using OrangeShotStudio.Application;

namespace OrangeShotStudio.TanksGame
{
    public class ServerTanksGameController : BaseGameController
    {
        public ServerTanksGameController(ServerTanksGameStateFactory tanksGameStateFactory,
            IAnalyticsService analyticsService) : base(analyticsService)
        {
            GameState = tanksGameStateFactory.CreateServerState();
            GameState.Initialize();
        }

        protected override void PreStateChange()
        {
        }
    }
}