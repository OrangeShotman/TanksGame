using Common;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.Multiplayer;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class TankCollectionView : IUpdateImplementer<TankView>
    {
        private readonly int _userId;
        private readonly CameraView _cameraView;
        private CollectionUpdater<TankView> _collectionUpdater = new CollectionUpdater<TankView>();
        private GameData _gameData;
        private IPrefabProvider _prefabProvider;
        public Vector2 CameraProjection => _cameraView.CameraForwardProjection;

        public TankCollectionView(IPrefabProvider prefabProvider, int userId)
        {
            _prefabProvider = prefabProvider;
            _userId = userId;
            _cameraView = new CameraView(prefabProvider);
        }

        public void Update(GameData gameData)
        {
            _gameData = gameData;
            _collectionUpdater.ProcessUpdate(this);
        }

        public void Dispose()
        {
            _cameraView.Dispose();
            _collectionUpdater.Dispose(this);
        }

        ITable IUpdateImplementer<TankView>.GetTable()
        {
            return _gameData.World.Avatar;
        }

        CreationResult<TankView> IUpdateImplementer<TankView>.Factory(uint entityId, int entityIndex)
        {
            var tank = new TankView(_prefabProvider);
            var avatar = _gameData.World.Avatar[entityId];
            if (avatar.OwnerUserId == _userId)
                _cameraView.SetTarget(tank.Tank.transform);
            return new CreationResult<TankView>()
            {
                IsCreated = true,
                Result = tank
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