using System;
using System.Text.RegularExpressions;

public class Example
{
	public static object Assert { get; private set; }

	public static void Main()
	{
		string pattern = @"\""?([^\""""]*)\""?"" (\d{2}) (\d{5}.\d{2}) (\d{10})";
		string input = @"""Mattias Asplund"" 46 35000.00 0706186120";
		//string output = "Asplund, Mattias (Lön: 35000,00 SEK) Telefon:070-6186120 Födelseår:1971";
		Match m = Regex.Match(input, pattern);
        var inputName= m.Groups[1].Value;
		var inputÅlder = m.Groups[2].Value;
		var inputLön = m.Groups[3].Value;
		var inputtel = m.Groups[4].Value;

		var outputName = Convert.ToString();
		Console.ReadLine();
	}
}