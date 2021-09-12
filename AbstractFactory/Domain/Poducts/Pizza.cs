using System.Collections;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public abstract class Pizza: MassaBase
	{
		public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
		{

		}
	}
}
