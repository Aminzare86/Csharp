using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RäknaSistaSifro
{
	class Program
	{
		static void Main(string[] args)
		{
			var finaly = 0;
			do
			{
			Console.WriteLine("Inter your person nr");
			var personNr =Console.ReadLine();
			int[] arr = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
			var peronArr = personNr.ToArray().Select(ch => int.Parse(ch.ToString())).ToArray();
			var total=0;
			var sut=0;
			for (int i = 0; i <= 8; i++)
			{
				 sut = (peronArr[i]) * (arr[i]);
				if (sut > 9)
				{					
					var sutToChar = Convert.ToString(sut);
					var sutToIntArray = sutToChar.ToArray().Select(ch => int.Parse(ch.ToString())).ToArray();
					sut = (sutToIntArray[1]) + (sutToIntArray[0]);
					total += sut;					
				}
				else
				{
					total += sut;
				}
				if (total <= 30)
				{
					finaly = 30 - total;
				}
				else if (total > 30 && total <= 40)
				{
					finaly = 40 - total;
				}
				else if (total > 40 && total <= 50)
				{
					finaly = 50 - total;
				}
				else if (total > 50 && total <= 60)
				{
					finaly = 60 - total;
				}
				else if (total > 60 && total <= 70)
				{
					finaly = 70 - total;
				}
			}	
			Console.WriteLine("its your Answer {0}",finaly);

			} while (finaly>=0);
			
		}
	}
}
