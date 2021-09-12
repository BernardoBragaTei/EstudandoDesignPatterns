using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public class PizzaFactory : MassasAbstractFactory
	{
		public override MassaBase CriarMassa(TipoMassa tipoMassa)
		{
			var tipoPizza = (TipoPizza)tipoMassa;
			switch (tipoPizza)
			{
				case TipoPizza.Calabresa:
					return new PizzaCalabresa();
				case TipoPizza.Mussarela:
					return new PizzaMussarela();
				default:
					throw new ArgumentOutOfRangeException("Tipo não implementado");
			}
		}
	}
}