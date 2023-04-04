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
            if (tankTransform.position == transform.Position)
                return;
            tankTransform.position = transform.Position;
            if (transform.Forward != Vector2.zero)
                tankTransform.forward = new Vector3(transform.Forward.x, 0, transform.Forward.y);
        }

        public void Dispose()
        {
            Object.Destroy(Tank.gameObject);
        }
    }
}