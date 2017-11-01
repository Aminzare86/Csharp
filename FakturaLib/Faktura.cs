using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLib
{
    public class Faktura
    {
		public string Street;
		public decimal Belopp;
		private Person kund;

		public Faktura()
		{
		}

		public Faktura(Person kund)
		{
			this.kund = kund;
		}
		public Person Kund { get; set; }
	}	
}
