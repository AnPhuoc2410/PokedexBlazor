namespace Pokedex.Components.Util
{
    public static class CalculateStat
    {
        public static int GetMinValue(int baseStat)
        {
            // Example calculation for minimum stat value
            return (int)(baseStat * 0.5);
        }

        public static int GetMaxValue(int baseStat)
        {
            // Example calculation for maximum stat value
            return (int)(baseStat * 2);
        }
    }
}
