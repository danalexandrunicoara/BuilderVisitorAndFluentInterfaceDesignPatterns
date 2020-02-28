using System;
using System.Reflection;

namespace BuilderVisitorAndFluentInterfaceDesignPatterns.FluentInterface
{
	public class FluentTransfer : IAction, IWrite, IRead
	{
		private readonly string _connectionString;

		private FluentTransfer(string connectionString)
		{
			_connectionString = connectionString;
		}

		public IRead Action()
		{
			var m = MethodBase.GetCurrentMethod();
			Console.WriteLine(m.Name);

			return this;
		}

		public IWrite Read()
		{
			var m = MethodBase.GetCurrentMethod();
			Console.WriteLine(m.Name);

			return this;
		}

		public void Write()
		{
			var m = MethodBase.GetCurrentMethod();
			Console.WriteLine(m.Name);
		}

		public static IAction Connect(string connectionString)
		{
			return new FluentTransfer(connectionString);
		}
	}

	public interface IWrite
	{
		void Write();
	}

	public interface IAction
	{
		IRead Action();
	}

	public interface IRead
	{
		IWrite Read();
	}
}