using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLibb
{
	public class Produkt
	{
		public Produkt(string namn, decimal pris)
		{
			if (pris < 0)
				throw new InvalidOperationException("Pris måste vara större än 0");
			this.Namn = namn;
			this.Pris = pris;
		}
		public string Namn { get; set; }
		public decimal Pris { get; set; }
		public override string ToString()
		{
			return this.Namn;
		}
	}
}
