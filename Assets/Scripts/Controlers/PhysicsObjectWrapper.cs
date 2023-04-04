using UnityEngine;

namespace OrangeShotStudio.TanksGame
{
    public class PhysicsObjectWrapper
    {
        private readonly GameObject _gameObject;
        private readonly CharacterController _characterController;

        public PhysicsObjectWrapper(GameObject gameObject)
        {
            _gameObject = gameObject;
            _characterController = gameObject.GetComponent<CharacterController>();
        }

        public void SetPosition(Common.World.Transform transform)
        {
            _gameObject.transform.position = transform.Position;
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