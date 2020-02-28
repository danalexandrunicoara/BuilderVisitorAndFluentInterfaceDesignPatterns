using System;
using System.Collections.Generic;

namespace BuilderVisitorAndFluentInterfaceDesignPatterns.BuilderDesignPattern
{
	public class Product
	{
		private readonly IList<string> _parts = new List<string>();

		public void Add(string part)
		{
			_parts.Add(part);
		}

		public void GetResult()
		{
			foreach (var part in _parts) Console.WriteLine(part);
		}
	}
}