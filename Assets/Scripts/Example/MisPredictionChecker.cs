using OrangeShotStudio.Multiplayer.Input;
using UnityEngine;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class MisPredictionChecker : IMispredictionChecker<GameData>
    {
        private readonly int _userId;

        public MisPredictionChecker(int userId)
        {
            _userId = userId;
        }

        public bool HasMissPrediction(GameData predicted, GameData serverTick)
        {
            var count = predicted.World.Player.Count;
            for (int i = 0; i < count; i++)
            {
                var player = predicted.World.Player.CmpAt(i);
                if (player.UserId == _userId)
                {
                    var avatar = predicted.GetAvatarEntity(player);
                    if (avatar == null)
                        return true;
                    var id = avatar.Id;
                    var predictedObject = predicted.World.Transform[id];
                    var serverObject = serverTick.World.Transform[id];
                    if (serverObject == null)
                    {
                        Debug.LogError($"Misprediction");
                        return true;
                    }

                    if ((predictedObject.Position - serverObject.Position).sqrMagnitude > 0.01f)
                    {
                        Debug.LogError(
                            $"Misprediction predictedTick:{predicted.Tick} serverTick:{serverTick.Tick}, predicted pos:{predictedObject.Position}, server pos:{serverObject.Position}");
                        return true;
                    }
                    // else
                    // {
                    //     Debug.Log(
                    //         $"Misprediction predictedTick:{predicted.Tick} serverTick:{serverTick.Tick}, predicted pos:{predictedObject.Position}, server pos:{serverObject.Position}");
                    // }
                }
            }

            return false;
        }
    }
}