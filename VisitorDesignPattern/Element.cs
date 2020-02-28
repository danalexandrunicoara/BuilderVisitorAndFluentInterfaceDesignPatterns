namespace BuilderVisitorAndFluentInterfaceDesignPatterns.VisitorDesignPattern
{
	public class Element
	{
		public Element(string name)
		{
			Name = name;
		}

		public string Name { get; }

		public void Accept(Visitor visitor)
		{
			visitor.Visit(this);
		}
	}
}