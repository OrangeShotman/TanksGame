using OrangeShotStudio.Analytics;
using OrangeShotStudio.Application;
using OrangeShotStudio.Provider;

namespace OrangeShotStudio.TanksGame
{
    public class ServerTanksGameCompositionRoot : ICompositionRoot
    {
        public void Launch()
        {
            UnityEngine.Application.targetFrameRate = StaticSettings.TickRate * 2;
            var prefabProvider = new PrefabProvider();
            var stateFactory = new ServerTanksGameStateFactory(prefabProvider);
            var analyticManager = new AnalyticManager();
            new ServerTanksGameController(stateFactory, analyticManager);
        }
    }
}