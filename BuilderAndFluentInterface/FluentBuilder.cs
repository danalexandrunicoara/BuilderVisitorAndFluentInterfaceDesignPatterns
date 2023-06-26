namespace BuilderAndFluentInterface
{
    public class FluentBuilder : IDescription, IName, IReset, ISetItem, IBuild
    {
        private Item _item;
        private FluentBuilder(Item item) => _item = item;

        public static ISetItem SetItem(Item item)
        {
            return new FluentBuilder(item);
        }

        public IReset Reset()
        {
            _item = new Item();
            return this;
        }

        public IDescription WithDescription(string description)
        {
            _item.Description = description;
            return this;
        }

        public IName WithName(string name)
        {
            _item.Name = name;
            return this;
        }

        public Item Build() => _item;
    }
}