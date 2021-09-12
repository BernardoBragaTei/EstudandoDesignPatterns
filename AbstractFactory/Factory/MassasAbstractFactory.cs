using AbstractFactory.Domain.Enums;
using System;

namespace AbstractFactory.Domain.Products
{
	public abstract class MassasAbstractFactory
	{
		public abstract MassaBase CriarMassa(TipoMassa tipoMassa);

		public static MassasAbstractFactory CriarFabricaMassas(TipoMassa tipoMassa)
		{
			switch (tipoMassa)
			{
				case TipoMassa.Bolo:
					return new BoloFactory();					
				case TipoMassa.Pizza:
					return new PizzaFactory();
				default:
					throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null);					
			}
		}
	}
}
