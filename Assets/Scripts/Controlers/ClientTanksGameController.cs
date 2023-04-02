using OrangeShotStudio.Analytics;
using OrangeShotStudio.Application;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class ClientTanksGameController : BaseGameController
    {
        private readonly InterfaceView _interfaceView;

        public ClientTanksGameController(ClientTanksGameStateFactory clientTanksGameStateFactory,
            InterfaceView interfaceView,
            IAnalyticsService analyticsService)
            : base(analyticsService)
        {
            _interfaceView = interfaceView;
            GameState = clientTanksGameStateFactory.CreateMainMenuState();
            GameState.Initialize();
        }

        protected override void PreStateChange()
        {
            _interfaceView.HideAll();
        }
    }
}