using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using EmployeeLib;
namespace RegexConvert
{
	[TestClass]
	public class ConvertString
	{
		[TestMethod]
		public void TestMethod1()
		{
			string input = @"""""""Mattias Asplund"""" 46 35000.00 070-6186120""";
			var sut = new Converter();
			string actual = sut.EmployeeConverter(input);

			Assert.AreEqual("Asplund, Mattias (Lön: 35000,00 SEK) Telefon:070-6186120 Födelseår:1971",actual);

		}
	}
}
