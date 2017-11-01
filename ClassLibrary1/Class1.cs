using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Class1
    {
		public void CanRead()
		{
			//Dictionary<string, decimal> accounts = new Dictionary<string,decimal>();
			var accounts = new Dictionary<string, decimal>();
			var streamReader = File.OpenText(@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
			while (true)
			{
				var Line = streamReader.ReadLine();
				if (Line == null)
					break;
				string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
				var match = Regex.Match(Line, pattern);
				if (match.Success)
				{
					var accountId = match.Groups[1].Value;
					var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
					if (accounts.ContainsKey(accountId))
					{
						accounts[accountId] += amount;
					}
					else
					{
						accounts[accountId] = amount;
					}
				}
				//F2:Fix number of decimal point		
			}
			foreach (var entry in accounts.OrderBy(e => e.Key))
				Debug.WriteLine($"{entry.Key}{entry.Value.ToString("F2") }");
			{
			}
			Debug.WriteLine(accounts.Sum(entry => entry.Value));
		}


	}
}
