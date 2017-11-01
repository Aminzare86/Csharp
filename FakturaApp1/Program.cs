using FakturaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FakturaApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            var kund = new Person();
			var Faktura = new Faktura();
			Faktura.Kund = kund;
			Console.WriteLine("Enter your Adress : ");
			var adress = Console.ReadLine();
			Faktura.Street = adress;
			Console.WriteLine("Enter your Products name : ");
			var productsName = Console.ReadLine();
			Console.WriteLine("Enter your Products price : ");
			var productsPrice = Convert.ToDecimal(Console.ReadLine());
			var product = new Product(productsName, productsPrice);
			Console.WriteLine("Enter your antal Products  : ");
			var antalProducts = Convert.ToInt32(Console.ReadLine());
			var enNyBeställning = new Beställning(kund);
			var enNyRad = new BeställningsRad(product, antalProducts);
			enNyBeställning.LäggtillRad(enNyRad);
			var enNyFaktura = Accounting.GenereraFaktura(enNyBeställning);
			Console.ReadLine();
		}
	}
}
