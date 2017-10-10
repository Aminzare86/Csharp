using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeLib
{
	public class Converter
	{
		public string EmployeeConverter(string input)
		{
			string pattern = @"\""""(\w+) (\w+)\"""" (\d{1,3}) (\d*.\d*) (.*)""";
			Match match = Regex.Match(input, pattern);
			var Lön = decimal.Parse(match.Groups[4].Value, CultureInfo.InvariantCulture);
			var telefon = match.Groups[5].Value;
			var age = int.Parse(match.Groups[3].Value);
			var year = DateTime.Now.AddYears(-age).Year;
			return $"{match.Groups[2].Value}, {match.Groups[1].Value} (Lön: {Lön} SEK) Telefon:{telefon} Födelseår:{year}";
		}
	}
}
