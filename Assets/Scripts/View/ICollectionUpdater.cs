namespace OrangeShotStudio.TanksGame.View
{
    public interface ICollectionUpdater<T>
    {
        void ProcessUpdate(IUpdateImplementer<T> updater);
        void Dispose(IUpdateImplementer<T> updater);
        T GetById(uint id);
    }
}