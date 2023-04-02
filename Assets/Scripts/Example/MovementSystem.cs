using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class MovementSystem : BaseSystem<GameData>
    {
        private readonly IInputStorage<GameData> _inputStorage;

        public MovementSystem(IInputStorage<GameData> inputStorage)
        {
            _inputStorage = inputStorage;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.Player.Count;
            for (int i = 0; i < count; i++)
            {
                var player = data.World.Player.CmpAt(i);
                player.InputIsAcknowledged = _inputStorage.TryGetInput(player.UserId, data.Tick, out var input);

                if (player.InputIsAcknowledged)
                {
                    var id = data.World.Player.IdAt(i);
                    var testObject = data.World.TestObject[id];
                    if (testObject == null)
                        testObject = data.World[id].AddTestObject();
                    // Debug.Log(
                    //     $"Movement:{input.Input.PlayerInput.CmpAt(0).Movement * 5 * (float)timeData.DeltaTimeMs * 0.001f} + {testObject.Position}, tick:{data.Tick}");

                    testObject.Position +=
                        input.Input.PlayerInput.CmpAt(0).Movement * 5 * (float)timeData.DeltaTimeMs * 0.001f;
                    var testObjectPredicted = data.World[id].AddTestObjectPredicted();
                    data.World.CopyTestObjectPredicted(testObjectPredicted, testObject);
                }
            }
        }
    }
}