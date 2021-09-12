using AbstractFactory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Domain.Products
{
	public class BoloFactory : MassasAbstractFactory
	{
		public override MassaBase CriarMassa(TipoMassa tipoMassa)
		{
			TipoBolo tipoBolo = (TipoBolo)tipoMassa;

			switch (tipoBolo)
			{
				case TipoBolo.Chocolate:
					return new BoloChocolate();
				case TipoBolo.Laranja:
					return new BoloLaranja();
				default:
					throw new ArgumentOutOfRangeException("Tipo não implementado");
			}
		}
	}
}