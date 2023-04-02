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
        public GameData GetInput()
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
            if (_input.Input.PlayerInput.Count == 0)
                _input.Input.CreateEntity().AddPlayerInput();
            var playerInput = _input.Input.PlayerInput.CmpAt(0);
            playerInput.Movement = input;
            return _input;
        }

        public void Dispose()
        {
            _input.Dispose();
        }
    }
}