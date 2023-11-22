using FakePerson.Lib.Models.Names;

namespace FakePerson.Lib.Randomizers.Names;

public class RussianNameRandom : IRandom<RussianName>
{
    private readonly IEnumerable<string> _listOfLastNames;
    private readonly IEnumerable<string> _listOfFirstNames;
    private readonly IEnumerable<string> _listOfPatronymics;

    public RussianNameRandom()
    {
        _listOfLastNames = new[] { "Сидоров", "Иванов", "Петров" };
        _listOfFirstNames = new[] { "Иван", "Пётр", "Василий" };
        _listOfPatronymics = new[] { "Иванович", "Петрович", "Васильевич" };
    }

    public RussianName Get()
    {
        var random = new Random();
        return new RussianName()
        {
            LastName = random.NextString(_listOfLastNames),
            FirstName = random.NextString(_listOfFirstNames),
            Patronymic = random.NextString(_listOfPatronymics)
        };
    }
}