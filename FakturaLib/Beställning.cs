using System;
using System.Collections.Generic;
using System.Text;

namespace FakturaLib
{
     public class Beställning
     {
		public Beställning(Person person)
		{
			Person = person;
		}
		public void LäggtillRad(BeställningsRad rad)
		{
			Rader.Add(rad);
		}
		internal Person Person;
		public List<BeställningsRad> Rader = new List<BeställningsRad>();
	 }


}
