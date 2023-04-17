namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GameDataCopier : IFrameCopier<GameData>
    {
        public void Copy(GameData src, GameData dst)
        {
            src.CopyTo(dst);
        }
    }
}