using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class ProjectileView
    {
        private readonly ProjectileBehaviour _projectile;

        public ProjectileView(GameObject projectile)
        {
            _projectile = projectile.GetComponent<ProjectileBehaviour>();
        }

        public void Update(Common.Simulation.Transform transform)
        {
            var projectileTransform = _projectile.transform;
            if (projectileTransform.position == transform.Position)
                return;
            projectileTransform.position = transform.Position;
            if (transform.Forward != Vector2.zero)
                projectileTransform.forward = new Vector3(transform.Forward.x, 0, transform.Forward.y);
        }

        public void Dispose()
        {
            var instance = Object.Instantiate(_projectile.ExplosionFxPrefab, _projectile.transform.position,
                _projectile.transform.rotation);
            Object.Destroy(instance, 1);
            Object.Destroy(_projectile.gameObject, 1);
            _projectile.ProjectileRender.SetActive(false);
        }
    }
}