using System;
using Common;

namespace OrangeShotStudio.TanksGame.View
{
    public class CollectionUpdater<T> : ICollectionUpdater<T>
    {
        private uint[] _entities;
        private T[] _views;
        private int _count;

        public CollectionUpdater(int capacity = 10)
        {
            _entities = new uint[capacity];
            _views = new T[capacity];
        }

        public void ProcessUpdate(IUpdateImplementer<T> updater)
        {
            var entities = updater.GetTable();
            if (entities == null)
                return;
            
            var entitiesCount = entities.Count;
            int entityIndex = 0, viewIndex = 0;
            while (entityIndex != entitiesCount && viewIndex != _count)
            {
                uint ecsEntity = entities.IdAt(entityIndex), viewEntity = _entities[viewIndex];

                if (ecsEntity <= viewEntity)
                {
                    if (updater.HasEntityWithId(ecsEntity, entityIndex))
                    {
                        if (ecsEntity == viewEntity)
                        {
                            updater.Update(ecsEntity, entityIndex, _views[viewIndex]);
                            ++viewIndex;
                        }
                        else
                        {
                            if (AddNewEntity(updater, viewIndex, ecsEntity, entityIndex))
                            {
                                ++viewIndex;
                            }
                        }
                    }

                    ++entityIndex;
                }
                else
                {
                    DeleteEntity(updater, viewIndex);
                }
            }

            if (viewIndex < _count)
            {
                var delta = 0;
                for (; viewIndex < _count; viewIndex++, delta++)
                {
                    DisposeEntity(updater, viewIndex);
                }

                _count -= delta;
            }
            else
            {
                for (; entityIndex < entitiesCount; entityIndex++)
                {
                    var entityId = entities.IdAt(entityIndex);
                    if (updater.HasEntityWithId(entityId, entityIndex) && AddNewEntity(updater, viewIndex, entityId, entityIndex))
                    {
                        viewIndex++;
                    }
                }
            }
        }

        void DisposeEntity(IUpdateImplementer<T> updater, int index)
        {
            var view = _views[index];
            updater.Dispose(_entities[index], view);
            _views[index] = default;
            _entities[index] = default;
        }

        void DeleteEntity(IUpdateImplementer<T> updater, int viewIndex)
        {
            DisposeEntity(updater, viewIndex);
            
            var copyCount = _count - viewIndex - 1;
            if (copyCount > 0)
            {
                Array.Copy(_entities, viewIndex + 1, _entities, viewIndex, copyCount);
                Array.Copy(_views, viewIndex + 1, _views, viewIndex, copyCount);
            }

            _views[_count - 1] = default;
            _entities[_count - 1] = default;
            _count--;
        }

        bool AddNewEntity(IUpdateImplementer<T> updater, int viewIndex, uint entityId, int entityIndex)
        {
            if (!updater.HasEntityWithId(entityId, entityIndex))
            {
                return false;
            }

            var view = updater.Factory(entityId, entityIndex);
            if (view.IsCreated)
            {
                if (_count == _views.Length)
                {
                    var newCapacity = (int) Math.Max((_count * 1.5f), _count + 20);
                    Array.Resize(ref _entities, newCapacity);
                    Array.Resize(ref _views, newCapacity);
                }

                var copyCount = _count - viewIndex;
                if (copyCount > 0)
                {
                    Array.Copy(_entities, viewIndex, _entities, viewIndex + 1, copyCount);
                    Array.Copy(_views, viewIndex, _views, viewIndex + 1, copyCount);
                }

                _views[viewIndex] = view.Result;
                _entities[viewIndex] = entityId;
                _count++;

                updater.Update(entityId, entityIndex, _views[viewIndex]);
                
                return true;
            }

            return false;
        }
        
        public void Dispose(IUpdateImplementer<T> updater)
        {
            for (var i = 0; i < _count; i++)
            {
                DisposeEntity(updater, i);
            }
            
            _count = 0;
        }

        public T GetById(uint entityId)
        {
            var idx = _entities.BinarySearch(_count, entityId);
            if (idx >= 0)
            {
                return _views[idx];
            }
            
            return default;
        }
    }
}