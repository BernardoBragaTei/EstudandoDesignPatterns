using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
	public class PizzaCalabresa : Pizza
	{
		public PizzaCalabresa()
		{
			Nome = "Pizza de Calabresa";
		}

		public override void Assar(int tempo)
		{
			Console.WriteLine($"{Nome} assando por {tempo} min.");
		}

		public override void Embalar()
		{
			Console.WriteLine($"Embalando {Nome}.");
		}

		public override void Preparar()
		{
			Console.WriteLine($"Preparando {Nome}.");
		}
	}
}
