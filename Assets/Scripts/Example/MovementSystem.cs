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
                    var avatarEntity = data.GetAvatarEntity(player);
                    var transform = avatarEntity.Transform;
                    if (transform == null)
                        transform = avatarEntity.AddTransform();
                    if (input.Input.PlayerInput.Count < 1)
                        continue;
                    var motion = input.Input.PlayerInput.CmpAt(0).Movement.normalized * 5 *
                                 (float)timeData.DeltaTimeMs * 0.001f;
                    transform.Position += new Vector3(motion.x, 0, motion.y);
                    var testObjectPredicted = avatarEntity.AddTransformPredicted();
                    data.World.CopyTransformPredicted(testObjectPredicted, transform);
                }
            }
        }
    }
}