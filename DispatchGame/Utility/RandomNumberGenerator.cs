namespace DispatchGame.Utility;

public static class RandomNumberGenerator
{
    public static int Generate(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}