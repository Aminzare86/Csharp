using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SIELib
{
    public class Class1
    {
		public void Räknare()
		{
			var accounts = new Dictionary<string, decimal>();
			var streamReader = File.OpenText(@"SIE-bearbetning.txt");
			var totalLine = 0;
			while (true)
			{
				var Line = streamReader.ReadLine();
				if (Line == null)
					break;
				string pattern = @"(#TRANS) (\d{4}) {.*} (-?\d*.\d*)";
				var match = Regex.Match(Line, pattern);
				if (match.Success)
				{
					var accountId = match.Groups[1].Value;
					var amount = decimal.Parse(match.Groups[3].Value, CultureInfo.InvariantCulture);
					if (accounts.ContainsKey(accountId))
					{
						accounts[accountId] += amount;
						totalLine++;
					}
					else
					{
						accounts[accountId] = amount;
						totalLine++;
					}
				}

			}

			Console.WriteLine($"du har  { totalLine} rader");
			Console.WriteLine($"totalen av de belopp: { accounts.Sum(entry => entry.Value)}");
		}

	}
}
