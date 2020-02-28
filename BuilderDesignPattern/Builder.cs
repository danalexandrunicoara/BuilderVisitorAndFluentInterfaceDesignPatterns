namespace BuilderVisitorAndFluentInterfaceDesignPatterns.BuilderDesignPattern
{
	public class Builder
	{
		private readonly Product _product = new Product();

		public void Build(string part)
		{
			_product.Add(part);
		}

		public Product GetProduct()
		{
			return _product;
		}
	}
}