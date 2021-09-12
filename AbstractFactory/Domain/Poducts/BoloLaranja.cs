using AbstractFactory.Domain.Enums;
using System.Collections;

namespace AbstractFactory.Domain.Products
{
	public sealed class BoloLaranja : Bolo
	{
		public BoloLaranja(): base("Bolo de Laranja", TipoMassa.Bolo)
		{
			Ingredientes.Add("Com cobertura de calda de Laranja.");
		}
	}
}