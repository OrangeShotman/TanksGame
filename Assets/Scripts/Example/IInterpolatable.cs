namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public interface IInterpolatable<T>
    {
        void CopyTo(T dst);
        void Dispose();
    }
}