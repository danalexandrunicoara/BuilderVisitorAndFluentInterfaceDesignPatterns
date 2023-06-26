namespace BuilderAndFluentInterface
{
    public interface IName : IBuild
    {
        IDescription WithDescription(string description);
        IReset Reset();
    }
}