using System;
using Common;

namespace OrangeShotStudio.TanksGame.View
{
    public interface IUpdateImplementer<T> : IDisposable
    {
        ITable GetTable();
        CreationResult<T> Factory(uint entityId, int entityIndex);
        void Update(uint entityId, int entityIndex, T viewElement);
        void Dispose(uint entityId, T viewElement);
        bool HasEntityWithId(uint entityId, int entityIndex);
    }
}