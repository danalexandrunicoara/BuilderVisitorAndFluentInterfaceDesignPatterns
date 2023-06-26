namespace BuilderAndFluentInterface
{
    public interface ISetItem : IBuild
    {
        IName WithName(string name);
    }
}