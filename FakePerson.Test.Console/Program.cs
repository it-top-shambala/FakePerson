using System.Text.Encodings.Web;
using System.Text.Json;
using FakePerson.Lib.Factories;
using FakePerson.Lib.Factories.NameFactories;
using FakePerson.Lib.Randomizers;

var nameFactory = new RandomAbstractNameFactory(new RandomRussianNameFactory());
var personBuilder = new PersonBuilder(nameFactory.Create());
var random = new Random();

var person = personBuilder
    .SetAge(random.NextAge())
    .SetEmail("person@email.mail")
    .Build();

var jsonOptions = new JsonSerializerOptions()
{
    IncludeFields = true,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
};
var json = JsonSerializer.Serialize(person, jsonOptions);
Console.WriteLine(json);

Console.WriteLine(person);