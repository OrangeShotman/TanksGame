using Common;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame.View
{
    public class TankCollectionView : IUpdateImplementer<TankView>
    {
        private CollectionUpdater<TankView> _collectionUpdater = new CollectionUpdater<TankView>();
        private GameData _gameData;
        private IPrefabProvider _prefabProvider;

        public TankCollectionView(IPrefabProvider prefabProvider)
        {
            _prefabProvider = prefabProvider;
        }

        public void Update(GameData gameData)
        {
            _gameData = gameData;
            _collectionUpdater.ProcessUpdate(this);
        }

        public void Dispose()
        {
            _collectionUpdater.Dispose(this);
        }

        ITable IUpdateImplementer<TankView>.GetTable()
        {
            return _gameData.World.Avatar;
        }

        CreationResult<TankView> IUpdateImplementer<TankView>.Factory(uint entityId, int entityIndex)
        {
            return new CreationResult<TankView>()
            {
                IsCreated = true,
                Result = new TankView(_prefabProvider)
            };
        }

        void IUpdateImplementer<TankView>.Update(uint entityId, int entityIndex, TankView viewElement)
        {
            var transform = _gameData.World.Transform[entityId];
            viewElement.Update(transform);
        }

        void IUpdateImplementer<TankView>.Dispose(uint entityId, TankView viewElement)
        {
            viewElement.Dispose();
        }

        bool IUpdateImplementer<TankView>.HasEntityWithId(uint entityId, int entityIndex)
        {
            return _gameData.World.Transform[entityId] != null;
        }
    }
}