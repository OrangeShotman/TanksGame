using OrangeShotStudio.DB.Application;
using OrangeShotStudio.Provider;
using OrangeShotStudio.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        private int _userId = Random.Range(0,9999999);
        public ClientTanksGameStateFactory(IPrefabProvider prefabProvider, InterfaceView interfaceView) : base(prefabProvider,
            interfaceView)
        {
        }
    }
}