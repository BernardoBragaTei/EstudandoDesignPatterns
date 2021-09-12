using System.Collections;
using AbstractFactory.Domain.Enums;


namespace AbstractFactory.Domain.Products
{
	public sealed class PizzaCalabresa : Pizza
	{
		public PizzaCalabresa() : base("Pizza de Calabresa", TipoMassa.Pizza)
		{
			Ingredientes.Add("Com calabresa de não sei onde.");
		}
	}
}