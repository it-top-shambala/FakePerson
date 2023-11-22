using FakePerson.Lib.Models.Names;
using FakePerson.Lib.Randomizers;
using FakePerson.Lib.Randomizers.Names;

namespace FakePerson.Lib.Factories.NameFactories;

public class RandomRussianNameFactory : IFactory<RussianName>
{
    private readonly IRandom<RussianName> _random = new RussianNameRandom();

    public RussianName Create()
    {
        return _random.Get();
    }
}