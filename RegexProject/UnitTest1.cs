using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RegexProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//\"?([^\""]*)\"?" (\d{2}) (\d{5}.\d{2}) (\d{10})
			string pattern = @"\""?([^\""""]*)\""?"" (\d{2}) (\d{5}.\d{2}) (\d{10})";
			//"Mattias Asplund" 46 35000.00 0706186120
			string input = @"""Mattias Asplund"" 46 35000.00 0706186120";
			Match m = Regex.Match(input, pattern);
			Assert.AreEqual("Mattias Asplund", m.Groups[1].Value);
			Assert.AreEqual("46", m.Groups[2].Value);
			Assert.AreEqual("35000.00", m.Groups[3].Value);
			Assert.AreEqual("0706186120", m.Groups[4].Value);
			
		}
	}
}
