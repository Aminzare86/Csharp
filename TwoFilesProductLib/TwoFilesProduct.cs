using System;
using System.Globalization;
using System.IO;

namespace TwoFilesProductLib
{
	public class TwoFilesProduct
	{
		public static string Transform(string input1, string input2)
		{
			var stringReader1 = new StringReader(input1);
			string output = "";
			while (true)
			{
				var line1 = stringReader1.ReadLine();
				if (line1 == null)
					break;
				var stringReader2 = new StringReader(input2);
				while (true)
				{
					var line2 = stringReader2.ReadLine();
					if (line2 == null)
						break;
					var amount = decimal.Parse(line1, CultureInfo.InvariantCulture);
					var qty = int.Parse(line2);
					var product = amount * qty;
					// if you want run test you have to write /n instead for {Environment.NewLine}
					output += $"{line1}x{line2}={product.ToString(CultureInfo.InstalledUICulture)}{Environment.NewLine}";
				}
			}
			return output;

		}
	}
}
