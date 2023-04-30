using OrangeShotStudio.Network.FakeConnections;
using Pixockets.Pools;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class ConnectionBrokerBehaviour : MonoBehaviour
    {
        public FakeConnectionsBroker FakeConnectionsBroker => FakeNetwork.GetInstance();

        

        private void OnDestroy()
        {
            FakeConnectionsBroker.Dispose();
        }
    }
}