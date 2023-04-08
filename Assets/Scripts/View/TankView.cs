using System;
using Common.World;
using OrangeShotStudio.Provider;
using UnityEngine;
using Object = UnityEngine.Object;
using Transform = Common.World.Transform;

namespace OrangeShotStudio.TanksGame.View
{
    public class TankView
    {
        public readonly TankBehaviour Tank;
        private float _previousHealth;

        public TankView(IPrefabProvider prefabProvider)
        {
            var tankPrefab = prefabProvider.GetPrefab("Tank");
            Tank = Object.Instantiate(tankPrefab).GetComponent<TankBehaviour>();
        }

        public void Update(Transform transform, Health health)
        {
            UpdatePosition(transform);
            UpdateHealth(health);
        }

        public void Dispose()
        {
            Object.Destroy(Tank.gameObject);
        }

        private void UpdateHealth(Health health)
        {
            if (Math.Abs(_previousHealth - health.CurrentHealth) < 0.00001)
                return;
            int healthViewIndex = Mathf.CeilToInt(health.CurrentHealth / 33);
            if (healthViewIndex is < 3 and >= 1)
                Tank.Smoke.Play(true);
            else
                Tank.Smoke.Stop(true);
            if (healthViewIndex == 1)
                Tank.Fire.gameObject.SetActive(true);
            else
                Tank.Fire.gameObject.SetActive(false);

            Tank.TankRenderer.SetActive(healthViewIndex > 0);
            if (healthViewIndex < 1)
                Tank.Explosion.Play();
            _previousHealth = health.CurrentHealth;
        }

        private void UpdatePosition(Transform transform)
        {
            var tankTransform = Tank.transform;
            if (tankTransform.position == transform.Position)
                return;
            tankTransform.position = transform.Position;
            if (transform.Forward != Vector2.zero)
                tankTransform.forward = new Vector3(transform.Forward.x, 0, transform.Forward.y);
        }
    }
}