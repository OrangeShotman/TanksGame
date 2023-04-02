using System.Collections.Generic;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class PlayerHandlerSystem : BaseSystem<GameData>, IPlayerHandler
    {
        private List<int> _toAdd = new List<int>();
        private List<int> _toRemove = new List<int>();

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            data.ServerTick = data.Tick+1;
            // Debug.Log($"server tick: {data.Tick}");
            foreach (var userId in _toAdd)
            {
                var entity = data.World.CreateEntity();
                var player = entity.AddPlayer();
                player.UserId = userId;
                var testObject = entity.AddTestObject();
                testObject.Position = Random.insideUnitSphere * 3;
                Debug.Log($"add: {userId}");
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
                        var id = data.World.Player.IdAt(i);
                        var entity = data.World[id];
                        entity.DeleteAll();
                        Debug.Log($"remove: {userId}");

                        break;
                    }
                }

                data.World.DeleteEmptyEntities();
            }
            
            _toRemove.Clear();
        }

        public void OnPlayerAdd(int userId)
        {
            _toAdd.Add(userId);
        }

        public void OnPlayerRemove(int userId)
        {
            _toRemove.Add(userId);
        }
    }
}