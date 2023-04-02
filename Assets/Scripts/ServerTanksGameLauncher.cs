using OrangeShotStudio.Application;

namespace OrangeShotStudio.TanksGame
{
    public class ServerTanksGameLauncher : BaseLauncher
    {
        private readonly ICompositionRoot _cr = new ServerTanksGameCompositionRoot();

        protected override ICompositionRoot Cr => _cr;
    }
}