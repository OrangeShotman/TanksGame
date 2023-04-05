using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class ProjectileView
    {
        private readonly GameObject _projectile;

        public ProjectileView(GameObject projectile)
        {
            _projectile = projectile;
        }

        public void Update(Common.World.Transform transform)
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
            Object.Destroy(_projectile);
        }
    }
}