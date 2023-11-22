using FakePerson.Lib.Factories;
using FakePerson.Lib.Models.Names;

namespace FakePerson.Lib.Randomizers.Names;

public class SimpleNameRandom : IRandom<SimpleName>
{
    private readonly IEnumerable<string> _listOfNames;
    
    public SimpleNameRandom()
    {
        _listOfNames = new[] { "Сидоров", "Иванов", "Петров" };
    }

    public SimpleName Get()
    {
        var random = new Random();
        return new SimpleName()
        {
            FirstName = random.NextString(_listOfNames)
        };
    }
}