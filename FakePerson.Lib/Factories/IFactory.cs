namespace FakePerson.Lib.Factories;

public interface IFactory<out T>
{
    public T Create();
}