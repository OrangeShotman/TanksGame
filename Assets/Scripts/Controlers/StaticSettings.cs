using OrangeShotStudio.Multiplayer.Facade;

namespace OrangeShotStudio.TanksGame
{
    public static class StaticSettings
    {
        public const ConnectionType ConnectionType =
            OrangeShotStudio.Multiplayer.Facade.ConnectionType.WebSockets;

        public const GameClientSettings.GameClientUpdateType GameClientUpdateType =
            GameClientSettings.GameClientUpdateType.InCoroutine;

        public const int TickRate = 30;
        public const int TickRateChange = 6;
        public const float TickDurationSec = 1f / TickRate;
        public const float TickDurationMs = 1000f / TickRate;

        public static float TickToSec(this int tick)
        {
            return tick * TickDurationSec;
        }

        public static float TickToMs(this int tick)
        {
            return tick * TickDurationMs;
        }

        public static float SecToTick(this float sec)
        {
            return sec / TickDurationSec;
        }

        public static float MsToTick(this float ms)
        {
            return ms / TickDurationMs;
        }
    }
}