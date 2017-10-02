using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
	public class Part
	  {
		public Part(string namn,string juridisktId) {
		this.Namn=namn;
	    this.JuridisktId = juridisktId;
		}
		
		public string Namn { get; set; }
		public string JuridisktId { get; set; }
		public override string ToString()
		{
			return $"{Namn} ({JuridisktId})";
		}

	}
}
