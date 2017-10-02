using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parter;
namespace PartTestLib
{
	[TestClass]
	public class PartTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sut = new Part("Mohammad amin zare","19860112-1513");
			Assert.AreEqual("Mohammad amin zare (19860112-1513)",sut.ToString());
		}
	}
}
