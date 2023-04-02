using OrangeShotStudio.Analytics;
using OrangeShotStudio.Application;
using OrangeShotStudio.Provider;

namespace OrangeShotStudio.TanksGame
{
    public class ServerTanksGameCompositionRoot : ICompositionRoot
    {
        public void Launch()
        {
            var prefabProvider = new PrefabProvider();
            var stateFactory = new ServerTanksGameStateFactory(prefabProvider);
            var analyticManager = new AnalyticManager();
            new ServerTanksGameController(stateFactory, analyticManager);
        }
    }
}