using OrangeShotStudio.Multiplayer.Facade;

namespace OrangeShotStudio.TanksGame
{
    public static class StaticSettings
    {
        public const ConnectionType ConnectionType =
            OrangeShotStudio.Multiplayer.Facade.ConnectionType.WebSockets;

        public const GameClientSettings.GameClientUpdateType GameClientUpdateType =
            GameClientSettings.GameClientUpdateType.InThread;

        public const int TickRate = 20;
        public const int TickRateChange = 4;
        public const double TickDurationSec = 1d / TickRate;
        public const int TickDurationMs = (int)(1000d / TickRate);
        public const int FastTickDurationMs = (int)(1000d / (TickRateChange + TickRate));

        public static double TickToSec(this int tick)
        {
            return tick * TickDurationSec;
        }

        public static double TickToMs(this int tick)
        {
            return tick * TickDurationMs;
        }

        public static double SecToTick(this float sec)
        {
            return sec / TickDurationSec;
        }

        public static double MsToTick(this float ms)
        {
            return ms / TickDurationMs;
        }
    }
}