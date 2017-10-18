using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;
namespace SchoolTestsLib
{
	[TestClass]
	public class SchoolSystemTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sut = new SchoolSystem();
			sut.AddClass("spo16",20);
			sut.AddClass("spo15", 40);
			sut.AddClass("spo16", 10);
			Assert.AreEqual(2,sut.ClassCount);
			Assert.AreEqual(70, sut.StudentCount);
		}
	}
}
