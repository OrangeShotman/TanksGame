using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class InputProvider
    {
        private GameData _input;

        public InputProvider(GameDataFactory gameDataFactory)
        {
            _input = gameDataFactory.CreateMessage();
        }
        public GameData GetInput(Vector2 cameraProjection, int otherWorldTick)
        {
            Vector2 input = Vector2.zero; // new Vector3(Mathf.Sin(Time.time)*0.5f, Mathf.Cos(Time.time)*0.5f);
            if (Input.GetKey(KeyCode.W))
                input += Vector2.up;
            if (Input.GetKey(KeyCode.S))
                input += Vector2.down;
            if (Input.GetKey(KeyCode.A))
                input += Vector2.left;
            if (Input.GetKey(KeyCode.D))
                input += Vector2.right;
            var angle = Vector2.SignedAngle(Vector2.up, cameraProjection);
            input = Rotate(input, angle);
            input = new Vector2(Mathf.Sin(Time.time), 0);
            if (_input.Input.PlayerInput.Count == 0)
                _input.Input.CreateEntity().AddPlayerInput();
            var playerInput = _input.Input.PlayerInput.CmpAt(0);
            playerInput.Movement = input;
            playerInput.Shot = Input.GetKey(KeyCode.Space);
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