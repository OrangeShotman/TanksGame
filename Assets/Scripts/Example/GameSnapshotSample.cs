using System;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GameSnapshotSample
    {
        public GameData GameData { get; private set; }
        public int SampleTime { get; private set; }
        public int Tick { get; private set; }

        public GameSnapshotSample(GameData gameData)
        {
            GameData = gameData;
        }

        public void SetSample(GameData gameData, int tick)
        {
            gameData.CopyTo(GameData);
            SampleTime = Environment.TickCount;
            Tick = tick;
        }
    }
}