using OrangeShotStudio.DB.Application;
using OrangeShotStudio.Provider;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        private int _userId;
        public ClientTanksGameStateFactory(IPrefabProvider prefabProvider, InterfaceView interfaceView) : base(prefabProvider,
            interfaceView)
        {
        }
    }
}