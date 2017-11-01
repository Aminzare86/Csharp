using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakturaLib
{
     public class Accounting
     {
		public static Faktura GenereraFaktura(Beställning beställning)
		{
			var enFaktura = new Faktura(beställning.Person);
			Console.WriteLine(beställning.Rader.Sum(rad => rad.Antal * rad.Product.Price));
			return enFaktura;
		}
	}
}
