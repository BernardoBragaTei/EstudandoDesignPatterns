using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Soldado soldado = new Soldado() { Nome = "Cleito", Arma = "AK47", Acessorio = new Acessorio() { Nome = "Livro" } };
			Soldado soldadoShallow = (Soldado)soldado.Clone();
			Console.WriteLine(soldadoShallow.Acessorio.Nome);
			soldado.Acessorio.Nome = "Visão Noturna";
			Console.WriteLine(soldadoShallow.Acessorio.Nome);
		}
	}
}
