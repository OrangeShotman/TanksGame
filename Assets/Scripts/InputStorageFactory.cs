using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Network.Messages;
using OrangeShotStudio.TanksGame.Multiplayer;

namespace OrangeShotStudio.TanksGame
{
    public class InputStorageFactory : IInputStorageFactory<GameData>
    {
        private readonly InputStorage _inputStorage;

        public InputStorageFactory(IMessageDataFactory<GameData> messageDataFactory)
        {
            _inputStorage = new InputStorage(messageDataFactory, StaticSettings.TickRate * 10);
        }

        public IInputStorage<GameData> CreateInputStorage()
        {
            return _inputStorage;
        }

        public void Dispose()
        {
            _inputStorage.Dispose();
        }
    }
}