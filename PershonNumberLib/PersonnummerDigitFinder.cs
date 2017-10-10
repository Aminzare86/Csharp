using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PershonNumberLib
{
    public class PersonnummerDigitFinder
    {
		private string pershonNumberInput;
		public string LastDigit
		{ get
			{
				var total = 0;
				for (int pos = 0; pos < pershonNumberInput.Length; pos++)
				{
					var digit = int.Parse(pershonNumberInput[pos].ToString());
					if (pos % 2 == 0)
					{
						digit *= 2;
						if (digit > 9)
							digit -= 9;
					}
					total += digit;
				}
				var lastDigit = (10 - (total % 10)).ToString();
				return lastDigit;
			}
		}

		public void Proses(string PershonNumberInput)
		{
			this.pershonNumberInput = PershonNumberInput;
		}
	}
	
}
