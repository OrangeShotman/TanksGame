using OrangeShotStudio.TanksGame.View;
using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public class PhysicsObjectWrapper
    {
        private readonly GameObject _gameObject;
        private readonly CharacterController _characterController;

        public PhysicsObjectWrapper(GameObject gameObject, uint entityId)
        {
            _gameObject = gameObject;
            _characterController = gameObject.GetComponent<CharacterController>();
            var physicsObjectBehaviour = gameObject.GetComponent<PhysicsObjectBehaviour>();
            physicsObjectBehaviour.EntityId = entityId;
        }

        public void SetPosition(Common.World.Transform transform)
        {
            _gameObject.transform.position = transform.Position;
        }

        public void SetActive(bool active)
        {
            _gameObject.SetActive(active);
        }

        public Vector3 Move(Vector3 motion)
        {
            _characterController.Move(motion);
            return _characterController.transform.position;
        }


        public void Dispose()
        {
            Object.Destroy(_gameObject);
        }
    }
}