using System.Collections;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public sealed class BoloChocolate : Bolo
	{
		public BoloChocolate() : base("Bolo de Chocolate", TipoMassa.Bolo)
		{
			Ingredientes.Add("Com cobertura de chocolate.");
		}
	}
}