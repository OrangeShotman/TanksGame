using OrangeShotStudio.Multiplayer.Structuries;
using OrangeShotStudio.Multiplayer.Systems;
using OrangeShotStudio.Provider;
using OrangeShotStudio.TanksGame.Multiplayer;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OrangeShotStudio.TanksGame
{
    public class LevelInitializeSystem : BaseSystem<GameData>
    {
        private readonly IPrefabProvider _prefabProvider;
        private readonly Scene _scene;
        private GameObject _levelInstance;

        public LevelInitializeSystem(Scene scene, IPrefabProvider prefabProvider)
        {
            _scene = scene;
            _prefabProvider = prefabProvider;
        }

        public override void Initialize(GameData data, TimeData timeData)
        {
            var level = _prefabProvider.GetPrefab("Level");
            _levelInstance = Object.Instantiate(level);
            SceneManager.MoveGameObjectToScene(_levelInstance, _scene);
        }

        public override void Dispose()
        {
            Object.Destroy(_levelInstance);
            SceneManager.UnloadSceneAsync(_scene);
        }
    }
}