using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class InputSystem : BaseSystem<GameData>
    {
        private readonly IInputStorage<GameData> _inputStorage;

        public InputSystem(IInputStorage<GameData> inputStorage)
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
                    var avatarEntity = data.GetAvatarEntity(player);
                    var movementComponent = avatarEntity.Movement;
                    if (movementComponent == null)
                        movementComponent = avatarEntity.AddMovement();
                    if (input.Input.PlayerInput.Count < 1)
                        continue;
                    var inputSample = input.Input.PlayerInput.CmpAt(0);
                    movementComponent.Movement = inputSample.Movement.normalized * 5 *
                                                 (float)timeData.DeltaTimeMs * 0.001f;
                    if (inputSample.Shot)
                    {
                        var gun = avatarEntity.Gun;
                        gun.Use = true;
                    }
                }
            }
        }
    }
}