using OrangeShotStudio.TanksGame.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class InputProvider
    {
        private readonly IHudWindow _hudWindow;
        private GameData _input;

        public InputProvider(GameDataFactory gameDataFactory, IHudWindow hudWindow)
        {
            _hudWindow = hudWindow;
            _input = gameDataFactory.CreateMessage();
        }

        public GameData GetInput(Vector2 cameraProjection, int otherWorldTick)
        {
            Vector2 movement = Vector2.zero;
            bool attack = false;
            if (UnityEngine.Application.isMobilePlatform)
            {
                movement = _hudWindow.Movement;
                attack = _hudWindow.Attack;
            }
            else
            {
                if (Input.GetKey(KeyCode.W))
                    movement += Vector2.up;
                if (Input.GetKey(KeyCode.S))
                    movement += Vector2.down;
                if (Input.GetKey(KeyCode.A))
                    movement += Vector2.left;
                if (Input.GetKey(KeyCode.D))
                    movement += Vector2.right;
                if (Input.GetKey(KeyCode.Space))
                    attack = true;
            }
            var angle = Vector2.SignedAngle(Vector2.up, cameraProjection);
            movement = Rotate(movement, angle);
            movement = new Vector2(Mathf.Sin(Time.time), 0);
            if (_input.Input.PlayerInput.Count == 0)
                _input.Input.CreateEntity().AddPlayerInput();
            var playerInput = _input.Input.PlayerInput.CmpAt(0);
            playerInput.Movement = movement;
            playerInput.Shot = attack;
            playerInput.OtherWorldTick = otherWorldTick;
            return _input;
        }

        public void Dispose()
        {
            _input.Dispose();
        }
        
        private Vector2 Rotate(Vector2 v, float degrees) {
            float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
            float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);
         
            float tx = v.x;
            float ty = v.y;
            v.x = (cos * tx) - (sin * ty);
            v.y = (sin * tx) + (cos * ty);
            return v;
        }
    }
}