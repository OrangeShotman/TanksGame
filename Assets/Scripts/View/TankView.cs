using OrangeShotStudio.Provider;
using UnityEngine;
using Transform = Common.World.Transform;

namespace OrangeShotStudio.TanksGame.View
{
    public class TankView
    {
        public readonly TankBehaviour Tank;

        public TankView(IPrefabProvider prefabProvider)
        {
            var tankPrefab = prefabProvider.GetPrefab("Tank");
            Tank = Object.Instantiate(tankPrefab).GetComponent<TankBehaviour>();
        }

        public void Update(Transform transform)
        {
            var tankTransform = Tank.transform;
            if(tankTransform.position == transform.Position)
                return;
            var forward = transform.Position - tankTransform.position;
            tankTransform.position = transform.Position;
            tankTransform.forward = forward;
        }

        public void Dispose()
        {
            Object.Destroy(Tank.gameObject);
        }
    }
}