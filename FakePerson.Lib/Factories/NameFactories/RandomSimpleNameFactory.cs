using FakePerson.Lib.Models.Names;
using FakePerson.Lib.Randomizers;
using FakePerson.Lib.Randomizers.Names;

namespace FakePerson.Lib.Factories.NameFactories;

public class RandomSimpleNameFactory : IFactory<SimpleName>
{
    private readonly IRandom<SimpleName> _random = new SimpleNameRandom();
    public SimpleName Create()
    {
        return _random.Get();
    }
}