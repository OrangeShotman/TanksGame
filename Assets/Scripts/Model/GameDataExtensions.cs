using Common.World;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public static class GameDataExtensions
    {
        public static Entity GetAvatarEntity(this GameData gameData, Player player)
        {
            var count = gameData.World.Avatar.Count;
            for (int i = 0; i < count; i++)
            {
                var avatar = gameData.World.Avatar.CmpAt(i);
                if (avatar.OwnerUserId == player.UserId)
                {
                    var id = gameData.World.Avatar.IdAt(i);
                    return gameData.World[id];
                }
            }

            return null;
        }
    }
}