using FakePerson.Lib.Models;

namespace FakePerson.Lib.Factories;

public class PersonBuilder
{
    private readonly Person _person;

    public PersonBuilder(AbstractName name)
    {
        _person = new Person()
        {
            Name = name
        };
    }

    public PersonBuilder SetAge(int age)
    {
        _person.Age = age;
        return this;
    }
    
    public PersonBuilder SetPhone(AbstractPhone phone)
    {
        _person.Phone = phone;
        return this;
    }
    
    public PersonBuilder SetEmail(string email)
    {
        _person.Email = email;
        return this;
    }
    
    public PersonBuilder SetAddress(string address)
    {
        _person.Address = address;
        return this;
    }

    public Person Build() => _person;
}