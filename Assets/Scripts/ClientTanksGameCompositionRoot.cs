using OrangeShotStudio.Analytics;
using OrangeShotStudio.Application;
using OrangeShotStudio.Provider;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class ClientTanksGameCompositionRoot : ICompositionRoot
    {
        public void Launch()
        {
            var prefabProvider = new PrefabProvider();
            var windowsFactory = new TanksGameWindowsFactory(prefabProvider);
            var interfaceView = new InterfaceView(prefabProvider, windowsFactory);
            var stateFactory = new ClientTanksGameStateFactory(prefabProvider, interfaceView);
            var analyticManager = new AnalyticManager();
            new ClientTanksGameController(stateFactory, interfaceView, analyticManager);
        }
    }
}