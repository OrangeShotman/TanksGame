using OrangeShotStudio.Application;
using OrangeShotStudio.DB.Application;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class ResultState : BaseGameState
    {
        private readonly InterfaceView _interfaceView;

        public ResultState(InterfaceView interfaceView, ClientTanksGameStateFactory factory)
        {
            _interfaceView = interfaceView;
        }
    }

    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        public IGameState CreateResultState()
        {
            return new ResultState(InterfaceView, this);
        }
    }
}