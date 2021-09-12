using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Domain.Enums;


namespace AbstractFactory.Domain.Products
{
	public abstract class MassaBase
	{
		public TipoMassa TipoMassa { get; set; }
		public string Nome { get; set; }
		public ArrayList Ingredientes = new ArrayList();
		
		public MassaBase(string nome, TipoMassa tipo)
		{
			Nome = nome;
			TipoMassa = tipo;
		}

		public virtual void ExibirDetalhes()
		{
			Console.WriteLine($"Tipo: {TipoMassa}\n{Nome}\n{Ingredientes[0]}\n");
		}
	}
}