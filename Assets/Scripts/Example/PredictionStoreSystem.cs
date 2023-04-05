using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class PredictionStoreSystem : BaseSystem<GameData>
    {
        private readonly int _userId;

        public PredictionStoreSystem(int userId)
        {
            _userId = userId;
        }

        protected override void InternalUpdate(GameData data, TimeData timeData)
        {
            var count = data.World.Avatar.Count;
            for (int i = 0; i < count; i++)
            {
                var avatar = data.World.Avatar.CmpAt(i);
                if(avatar.OwnerUserId != _userId)
                    continue;
                var id = data.World.Avatar.IdAt(i);
                var entity = data.World[id];
                var transform = entity.Transform;
                var transformPredicted = entity.AddTransformPredicted();
                data.World.CopyTransformPredicted(transformPredicted, transform);
            }

            // count = data.World.Projectile.Count;
            // for (int i = 0; i < count; i++)
            // {
            //     var id = data.World.Projectile.IdAt(i);
            //     var entity = data.World[id];
            //     var transformPredicted = entity.AddTransformPredicted();
            //     data.World.CopyTransformPredicted(transformPredicted, entity.Transform);
            // }
        }
    }
}