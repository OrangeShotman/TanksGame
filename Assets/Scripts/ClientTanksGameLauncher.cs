using OrangeShotStudio.Application;

namespace OrangeShotStudio.TanksGame
{
    public class ClientTanksGameLauncher : BaseLauncher
    {
        private readonly ICompositionRoot _cr = new ClientTanksGameCompositionRoot();

        protected override ICompositionRoot Cr => _cr;
    }
}