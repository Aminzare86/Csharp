using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLib
{
     public class BeställningsRad
     {
		public BeställningsRad(Product product, int antal)
		{
			Product = product;
			Antal = antal;
		}
		internal Product Product;
		internal int Antal;
	 }

}
