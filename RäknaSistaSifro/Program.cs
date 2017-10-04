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
			Console.WriteLine("Inter your person nr");
			var personNr =Console.ReadLine();
			int[] arr = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
			var peronArr = personNr.ToArray().Select(ch => int.Parse(ch.ToString())).ToArray();
			int [] x = { };
			var total=0;
			var sut=0;
			var finaly = 0;
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
				finaly = 30 - total;
			}

			Console.WriteLine("its your Answer {0}",finaly);
			Console.ReadLine();


		}
	}
}
