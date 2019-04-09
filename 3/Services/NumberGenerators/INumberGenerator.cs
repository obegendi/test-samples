namespace Services.NumberGenerators
{
    public interface INumberGenerator
    {
        int GetRandom();

        int GetRandom(int min, int max);
    }
}