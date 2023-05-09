using System.Collections.Generic;
using BaseCode.Scripts.Templates.Controller;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.View;
using OrangeShotStudio.View;

namespace OrangeShotStudio.TanksGame
{
    public class TanksGameWindowsFactory : IWindowsFactory
    {
        private readonly IPrefabProvider _prefabProvider;

        public TanksGameWindowsFactory(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }

        public List<IWindow> CreateAllWindows()
        {
            return new List<IWindow>()
            {
                new SimpleMainMenuWindow(_prefabProvider),
                new HudWindow(_prefabProvider)
            };
        }
    }
}