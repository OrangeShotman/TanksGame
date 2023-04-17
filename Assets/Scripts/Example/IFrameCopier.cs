namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public interface IFrameCopier<T>
    {
        void Copy(T src, T dst);
    }
}