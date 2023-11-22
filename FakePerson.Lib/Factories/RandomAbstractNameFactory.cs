using FakePerson.Lib.Models;

namespace FakePerson.Lib.Factories;

public class RandomAbstractNameFactory : IFactory<AbstractName>
{
    private readonly IFactory<AbstractName> _factory;

    public RandomAbstractNameFactory(IFactory<AbstractName> factory)
    {
        _factory = factory;
    }

    public AbstractName Create()
    {
        return _factory.Create();
    }
}