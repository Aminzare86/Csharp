using FakturaLibb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaAppen
{
	class Program
	{
		static void Main(string[] args)
		{
			var fakturaSystem = new FakturaSystem();
			Console.WriteLine("Enter name : ");
			var name = Console.ReadLine();
			Console.WriteLine("Enter Id : ");
			var Id = Console.ReadLine();
			var enPerson = fakturaSystem.SkapaPart(name, Id);
			var beställning = fakturaSystem.SkapaBeställning(enPerson);
			var teddy = fakturaSystem.SkapaProdukt("Fredriksson", 79M);
			var ponny = fakturaSystem.SkapaProdukt("Miniponny", 15000M);
			Console.WriteLine("Enter antal teddy : ");
			var antalTaddy = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter antal ponny : ");
			var antalPonny = Convert.ToInt32(Console.ReadLine());

			try
			{
				beställning.NyRad(teddy, antalTaddy);
				beställning.NyRad(ponny, antalPonny);
				Console.WriteLine($"Beställningen är värd {beställning.Total}");
				var faktura = beställning.GenereraFaktura();
				Console.WriteLine(faktura);
				Console.ReadLine();
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine("Hoppsan. Försök igen lite senare.");
			}
		}
	}
}
