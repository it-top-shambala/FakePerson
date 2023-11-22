namespace FakePerson.Lib.Randomizers;

public static class RandomExtensions
{
    public static string NextString(this Random random, IEnumerable<string> source)
    {
        var list = source.ToList();
        var i = random.Next(0, list.Count);
        return list[i];
    }

    public static int NextAge(this Random random)
    {
        const int MIN_AGE = 0;
        const int MAX_AGE = 90;
        return random.Next(MIN_AGE, MAX_AGE + 1);
    }
}