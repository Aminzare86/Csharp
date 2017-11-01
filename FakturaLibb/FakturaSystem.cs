using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLibb
{
	public class FakturaSystem
	{
		public Part SkapaPart(string namn, string juridisktId)
		{
			var enPerson = new Part
			{
				Namn = namn,
				JuridisktId = juridisktId
			};
			return enPerson;
		}

		public Beställning SkapaBeställning(Part enPerson)
		{
			return new Beställning(enPerson);
		}

		public Produkt SkapaProdukt(string namn, decimal pris)
		{
			return new Produkt(namn, pris);
		}
	}
}
