using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
	public class Pizzaria
	{
		public static void SolicitarPizza()
		{
			Console.WriteLine("=======PIZZARIA SIMPLE FACTORY========");
			Console.WriteLine("Informe a Pizza (C)alabresa ou (M)ussarela? ");
			string tipo = Console.ReadLine().ToUpper();

			try
			{
				Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
				pizza.Preparar();
				pizza.Assar(10);
				pizza.Embalar();
				Console.WriteLine("Pizza concluída!");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro: {ex.Message}");
			}
		}
	}
}
