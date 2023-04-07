namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GameDataInterpolationStrategy : IInterpolationStrategy<GameData>
    {
        public void Interpolate(GameData result, GameData baseData, GameData nextData, float normalizedValue)
        {
            result.World.Interpolate(baseData.World, nextData.World, normalizedValue);
        }
    }
}