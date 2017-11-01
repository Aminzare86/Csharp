using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticLib
{
    public class PersonalInfo
    {
		public static string Convert(string content)
		{
			string pattern2 = @"(\d{4})-(\w+-\w+);(\w+ \w+);(\w+-\w+);";
			Match m = Regex.Match(content, pattern2);
			string convertPart1 = m.Groups[1].Value;
			string convertPart3 = m.Groups[3].Value;
			string convertPart4 = m.Groups[4].Value;
			var age = int.Parse(m.Groups[1].Value);
			var year = DateTime.Now.AddYears(-age).Year;
			string test = $"{convertPart3} är {year} år gammal och har telefonumret {convertPart4}";
			return test;
		}

		public static string Transform(string name, string Phone, string personNr)
		{
			string pattern = @"(\d{3})(\d{7})";
			Match m = Regex.Match(Phone, pattern);
			string Phonepart1 = m.Groups[1].Value;
			string Phonepart2 = m.Groups[2].Value;
			string editPhone = Phonepart1 + "-" + Phonepart2;
			string PershoInfo = personNr + ";" + name + ";" + editPhone + ";";
			return PershoInfo;
		}
	}
}
