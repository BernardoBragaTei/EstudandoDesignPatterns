using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
	public sealed class PizzaSimpleFactory
	{
		public static Pizza CriarPizza(string tipo)
		{
			Pizza pizza;
			switch (tipo)
			{
				case "C":
					pizza = new PizzaCalabresa();
					break;
				case "M":
					pizza = new PizzaMussarela();
					break;
				default:
					throw new ApplicationException($"A pizza de '{tipo}' não está disponível no cardápio.");
			}
			return pizza;
		}
	}
}
