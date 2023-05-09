using OrangeShotStudio.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public interface IHudWindow : IWindow
    {
        Vector2 Movement { get; }
        bool Attack { get; }
        void Update();
    }
}