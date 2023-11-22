namespace FakePerson.Lib.Randomizers;

public interface IRandom<out T>
{
    public T Get();
}