using Cinemachine;
using OrangeShotStudio.Provider;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.View
{
    public class CameraView
    {
        private readonly CinemachineVirtualCamera _virtualCamera;

        public Vector2 CameraForwardProjection
        {
            get
            {
                var projection = Vector3.ProjectOnPlane(_virtualCamera.transform.forward, Vector3.up);
                return new Vector2(projection.x, projection.z);
            }
        }
        public CameraView(IPrefabProvider prefabProvider)
        {
            var cameraPrefab = prefabProvider.GetPrefab("Camera");
            _virtualCamera = Object.Instantiate(cameraPrefab).GetComponent<CinemachineVirtualCamera>();
        }

        public void SetTarget(Transform transform)
        {
            _virtualCamera.Follow = transform;
            _virtualCamera.m_LookAt = transform;
        }

        public void Dispose()
        {
            Object.Destroy(_virtualCamera.gameObject);
        }
    }
}