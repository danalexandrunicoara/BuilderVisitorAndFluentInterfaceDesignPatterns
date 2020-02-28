using System;
using System.Collections.Generic;
using BuilderVisitorAndFluentInterfaceDesignPatterns.BuilderDesignPattern;
using BuilderVisitorAndFluentInterfaceDesignPatterns.FluentInterface;
using BuilderVisitorAndFluentInterfaceDesignPatterns.VisitorDesignPattern;

namespace BuilderVisitorAndFluentInterfaceDesignPatterns
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			#region Builder

			var builder = new Builder();
			builder.Build("part 1");
			builder.Build("part 2");
			builder.Build("part 3");

			var product = builder.GetProduct();
			product.GetResult();

			#endregion

			#region Visitor

			var elements = new List<Element>
			{
				new Element("Element 1"),
				new Element("Element 2")
			};

			var visitor = new Visitor();

			foreach (var element in elements) visitor.Visit(element);

			#endregion

			#region FluentInterface

			FluentTransfer
				.Connect("connectionString")
				.Action()
				.Read()
				.Write();

			#endregion

			Console.WriteLine("Hello World!");
		}
	}
}