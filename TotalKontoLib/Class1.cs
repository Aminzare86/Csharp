
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace TotalKontoLib
{
	public class Class1
	{
		public void Räknare()
		{
			var accountsSums =File.ReadAllLines(@"MATTIAS00_SIE4 2015-09-01 - 2016-08-31.SE.txt").
			Where(line => line.Contains("#TRANS")).
			GroupBy(line => Regex.Match(line, @"#TRANS (\d{4}) {} (-?\d*.\d*)").Groups[1].Value).
			Select(e => new
			{
				Account = e.Key,
				Total =
			  e.Sum(x => decimal.Parse(Regex.Match(x, @"#TRANS (\d{4}) {} (-?\d*.\d*)").Groups[2].Value,
			  System.Globalization.CultureInfo.InvariantCulture))
			}).
			OrderBy(e => e.Account);
			foreach (var item in accountsSums)
			{
				Console.WriteLine($"{item.Account} {item.Total}");
			};
		}
	}
}