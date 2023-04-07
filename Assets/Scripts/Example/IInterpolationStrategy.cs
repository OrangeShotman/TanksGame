namespace OrangeShotStudio.TanksGame.Multiplayer
{
    public interface IInterpolationStrategy<T>
    {
        void Interpolate(T result, T baseData, T nextData, float normalizedValue);
    }
}