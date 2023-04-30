using System.Collections.Generic;
using Common.World;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;
using ILogger = Pixockets.DebugTools.ILogger;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class PlayerHandlerSystem : BaseSystem<GameData>, IPlayerHandler
    {
        private object _locker = new object();
        private readonly ILogger _logger;
        private readonly List<int> _toAdd = new List<int>();
        private readonly List<int> _toRemove = new List<int>();

        public PlayerHandlerSystem(ILogger logger)
        {
            _logger = logger;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            data.ServerTick = data.Tick + 1;
            lock (_locker)
            {
                foreach (var userId in _toAdd)
                {
                    var entity = data.World.CreateEntity();
                    var player = entity.AddPlayer();
                    player.UserId = userId;
                    _logger.Info($"add: {userId}");
                    AttachAvatar(data, player);
                }

                _toAdd.Clear();

                foreach (var userId in _toRemove)
                {
                    var playerCount = data.World.Player.Count;
                    for (int i = 0; i < playerCount; i++)
                    {
                        var player = data.World.Player.CmpAt(i);
                        if (player.UserId == userId)
                        {
                            var avatarEntity = data.GetAvatarEntity(player);
                            var id = data.World.Player.IdAt(i);
                            var entity = data.World[id];
                            entity.DeleteAll();
                            avatarEntity.DeleteAll();
                            _logger.Info($"remove: {userId}");
                            break;
                        }
                    }

                    data.World.DeleteEmptyEntities();
                }

                _toRemove.Clear();
            }
        }

        private void AttachAvatar(GameData gameData, Player player)
        {
            var avatarEntity = gameData.GetAvatarEntity(player);
            if (avatarEntity != null)
                return;

            avatarEntity = gameData.World.CreateEntity();
            var avatarComponent = avatarEntity.AddAvatar();
            avatarComponent.OwnerUserId = player.UserId;
            var transform = avatarEntity.AddTransform();
            var position = Random.insideUnitCircle.normalized * 22;
            transform.Position = new Vector3(position.x, 0, position.y);
            transform.Forward = Random.insideUnitCircle.normalized;
            var physicsObject = avatarEntity.AddPhysicsObject();
            physicsObject.BodyType = PhysicsBodyType.PlayerBody;
            var gun = avatarEntity.AddGun();
            gun.CooldownDuration = StaticSettings.TickRate;
            gun.PositionOffset = 0.5f;
            var health = avatarEntity.AddHealth();
            health.CurrentHealth = 100;
            health.MaxHealth = 100;
        }

        void IPlayerHandler.OnPlayerAdd(int userId)
        {
            lock (_locker)
            {
                _toAdd.Add(userId);
            }
        }

        void IPlayerHandler.OnPlayerRemove(int userId)
        {
            lock (_locker)
            {
                _toRemove.Add(userId);
            }
        }
    }
}