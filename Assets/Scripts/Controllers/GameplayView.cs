using OrangeShotStudio.Network;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.Multiplayer;
using OrangeShotStudio.TanksGame.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public class GameplayView
    {
        private readonly IHudWindow _hudWindow;
        private readonly ClientInterpolator _clientInterpolator;
        private readonly TankCollectionView _tankCollectionView;
        private readonly ProjectileCollectionView _projectileCollectionView;
        public int LastRenderedServerTick { get; private set; }
        public Vector2 CameraProjection => _tankCollectionView.CameraProjection;

        public GameplayView(IHudWindow hudWindow, IPrefabProvider prefabProvider, GameDataFactory gameDataFactory,
            Common.Simulation.TableSet.Pools simulationPool, int userId)
        {
            _hudWindow = hudWindow;
            _clientInterpolator = new ClientInterpolator(gameDataFactory, simulationPool);
            _tankCollectionView = new TankCollectionView(prefabProvider, userId);
            _projectileCollectionView = new ProjectileCollectionView(prefabProvider);
        }

        public void Update(History<GameData> history, GameData currentSnapshot, SimulationData simulation)
        {
            var interpolated = _clientInterpolator.Interpolate(history, currentSnapshot, simulation);
            _tankCollectionView.Update(interpolated.GameData);
            _projectileCollectionView.Update(interpolated.SimulationData.Data);
            LastRenderedServerTick = interpolated.GameData.ServerTick;
            _hudWindow.Update();
        }

        public void Dispose()
        {
            _tankCollectionView.Dispose();
            _clientInterpolator.Dispose();
            _projectileCollectionView.Dispose();
        }
    }
}