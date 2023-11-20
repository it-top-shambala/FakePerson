namespace FakePerson.Lib.Models;

public abstract record AbstractPhone
{
    public required string Number { get; init; }
}