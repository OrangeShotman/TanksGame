using System.Threading.Tasks;
using OrangeShotStudio.CarDrift.View.UI;
using OrangeShotStudio.Provider;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class HudWindow : BaseWindow<HudWidget>, IHudWindow
    {
        public Vector2 Movement => Widget.JoystickControlButton.Pushed
            ? Widget.JoystickControlButton.CurrentDirection
            : Vector2.zero;

        public bool Attack => Widget.Attack.Pushed;

        public HudWindow(IPrefabProvider prefabProvider) : base(prefabProvider, "HudWindow")
        {
        }

        public void Update()
        {
            Widget.PushFieldBorder.SetActive(!Widget.JoystickControlButton.Pushed);
        }
    }
}