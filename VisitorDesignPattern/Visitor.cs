using System;

namespace BuilderVisitorAndFluentInterfaceDesignPatterns.VisitorDesignPattern
{
	public class Visitor
	{
		public void Visit(Element element)
		{
			Console.WriteLine(element.Name, GetType().Name);
		}
	}
}