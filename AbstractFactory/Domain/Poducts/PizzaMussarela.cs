using System.Collections;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public sealed class PizzaMussarela : Pizza
	{
		public PizzaMussarela() : base("Pizza de Mussarela", TipoMassa.Pizza)
		{
			Ingredientes.Add("Com mussarela de búfala");
		}
	}
}