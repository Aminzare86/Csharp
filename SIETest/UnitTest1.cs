using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIELib;

namespace SIETest
{
	[TestClass]
	public class UnitTest1
	{
		

		[TestMethod]
		public void TestMethod1()
		{
			var sut = new Class1();
			sut.Räknare();
			Assert.AreEqual("totalen av de belopp: 1822244",$"totalen av de belopp: { accounts.Sum(entry => entry.Value)}");

		}
	}
}
//du har  497 rader
//totalen av de belopp: 1822244