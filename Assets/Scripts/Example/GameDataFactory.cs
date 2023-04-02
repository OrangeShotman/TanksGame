using Common.Input;
using OrangeShotStudio.Network;
using OrangeShotStudio.Network.Messages;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class InputProvider
    {
        private History<GameData> _history;

        public InputProvider(GameDataFactory gameDataFactory, int inputHistorySize)
        {
            var array = new GameData[300];
            for (int i = 0; i < 300; i++)
            {
                array[i] = gameDataFactory.CreateMessage();
            }

            _history = new History<GameData>(array);

        }
        // public GameData GetInput()
        // {
        //     
        // }

        public void Dispose()
        {
            foreach (var gameData in _history)
            {
                gameData.Dispose();
            }
        }
    }
    public class GameDataFactory : IMessageDataFactory<GameData>
    {
        private TableSet.Pools _pools;
        private readonly Common.World.TableSet.Pools _worldPools;
        private TableSet.Packer _inputPacker;
        private readonly Common.World.TableSet.Packer _worldPacker;

        public GameDataFactory(TableSet.Pools pools, Common.World.TableSet.Pools worldPools)
        {
            _pools = pools;
            _worldPools = worldPools;
            _inputPacker = new TableSet.Packer();
            _worldPacker = new Common.World.TableSet.Packer();
        }
        public GameData CreateMessage()
        {
            return new GameData(_pools, _worldPools,  _inputPacker, _worldPacker);
        }
    }
}