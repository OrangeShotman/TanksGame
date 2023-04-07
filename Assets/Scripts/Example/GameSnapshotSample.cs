using System;
using OrangeShotStudio.Multiplayer.Input;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GameSnapshotSample<T> where T : IInterpolatable<T>
    {
        public T GameData { get; private set; }
        public int SampleTime { get; private set; }
        public int Tick { get; private set; }

        public GameSnapshotSample(T gameData)
        {
            GameData = gameData;
        }

        public void SetSample(T gameData, int tick)
        {
            gameData.CopyTo(GameData);
            SampleTime = Environment.TickCount;
            Tick = tick;
        }
    }
}