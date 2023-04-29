using Common.Input;
using OrangeShotStudio.Multiplayer.Facade;
using OrangeShotStudio.Multiplayer.Input;
using OrangeShotStudio.Network.Messages;
using OrangeShotStudio.Packer;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GameData : IGameData<GameData>, IMessageData, IInputSample, IInterpolatable<GameData>
    {
        private readonly TableSet.Packer _inputPacker;
        private readonly Common.World.TableSet.Packer _worldPacker;
        public TableSet Input { get; }
        public Common.World.TableSet World { get; }
        public int Tick { get; set; }
        public int ServerTick { get; set; }
        public int ApplyToTick => Tick;
        public int ByteLength => 1024;

        public GameData(TableSet.Pools pools, Common.World.TableSet.Pools worldPool, TableSet.Packer inputPacker,
            Common.World.TableSet.Packer worldPacker)
        {
            _inputPacker = inputPacker;
            _worldPacker = worldPacker;
            Input = new TableSet(pools);
            World = new Common.World.TableSet(worldPool);
        }

        public void Serialize(BitPacker bitPacker)
        {
            bitPacker.PackSInt32(Tick);
            bitPacker.PackSInt32(ServerTick);
            _inputPacker.Pack(Input, bitPacker);
            _worldPacker.Pack(World, bitPacker);
        }

        public void Deserialize(BitUnpacker bitUnpacker)
        {
            Tick = bitUnpacker.UnpackSInt32();
            ServerTick = bitUnpacker.UnpackSInt32();
            _inputPacker.Unpack(Input, bitUnpacker);
            _worldPacker.Unpack(World, bitUnpacker);
        }

        public void CopyTo(GameData destination)
        {
            destination.Input.Copy(Input);
            destination.World.Copy(World);
            destination.Tick = Tick;
            destination.ServerTick = ServerTick;
        }

        public void MergeWithPredicted(GameData destination)
        {
            destination.Input.Copy(Input);
            destination.World.MergeWithPredicted(World);
            destination.ServerTick = ServerTick;
        }

        bool IGameData<GameData>.InputIsAcknowledged(int userId)
        {
            var count = World.Player.Count;
            for (int i = 0; i < count; i++)
            {
                var player = World.Player.CmpAt(i);
                if (player.UserId != userId)
                    continue;
                return player.InputIsAcknowledged;
            }

            Debug.LogError("Can't find player");

            return false;
        }

        public void Dispose()
        {
            World.Clear();
            Input.Clear();
        }
    }
}