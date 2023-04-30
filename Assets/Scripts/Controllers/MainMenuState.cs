using BaseCode.Scripts.Templates.Controller;
using OrangeShotStudio.Application;
using OrangeShotStudio.DB.Application;
using OrangeShotStudio.Structuries;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class MainMenuState : BaseGameState
    {
        private readonly InterfaceView _interfaceView;
        private readonly ClientTanksGameStateFactory _factory;
        private SimpleMainMenuWindow _simpleMainMenuWindow;

        public MainMenuState(InterfaceView interfaceView, ClientTanksGameStateFactory factory)
        {
            _interfaceView = interfaceView;
            _factory = factory;
        }

        public override void Initialize()
        {
            _simpleMainMenuWindow = _interfaceView.GetWindow<SimpleMainMenuWindow>();
            _simpleMainMenuWindow.Show();
        }

        public override void Update(TimeData timeData)
        {
            if (_simpleMainMenuWindow.Start)
            {
                NextState = _factory.CreateGameplayState();
            }
        }
    }
    public partial class ClientTanksGameStateFactory : BaseGameStateFactory
    {
        public IGameState CreateMainMenuState()
        {
            return new MainMenuState(InterfaceView, this);
        }
    }
}