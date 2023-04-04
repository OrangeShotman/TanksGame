using System;

namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public class GameSnapshotSample
    {
        public GameData GameData { get; private set; }
        public int SampleTime { get; private set; }
        public int Tick { get; private set; }
        public int TickDurationMs { get; private set; }

        public GameSnapshotSample(GameData gameData)
        {
            GameData = gameData;
        }

        public void SetSample(GameData gameData, int tick, int tickDurationMs)
        {
            TickDurationMs = tickDurationMs;
            gameData.CopyTo(GameData);
            SampleTime = Environment.TickCount;
            Tick = tick;
        }
    }
}