using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTestLib;
using CalculatorLib;
using System.Diagnostics;

namespace CalculatorTestLib
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void SimpleDisply()
		{
			//Arrange
			Calculator sut = new Calculator();
			//Act
			sut.PowerOn();
			//Assert
			Assert.AreEqual(0,sut.Display);
		}
		[TestMethod]
		public void OneDigitInDisplay()
		{
			//Arrange
			var sut = new Calculator();
			//Act
			sut.Press("7");
			//Assert
			Assert.AreEqual(7, sut.Display);

		}
		[TestMethod]
		public void TwoDigitInDisplay()
		{
			//Arrange
			var sut = new Calculator();
			//Act
			sut.Press("5");
			sut.Press("2");
			//Assert
			Assert.AreEqual(52, sut.Display);
		}
		[TestMethod]
		public void Add12and25()
		{
			//Arrange
			var sut = new Calculator();
			//Act
			sut.Press("1");
			sut.Press("2");
			sut.Press("+");
			sut.Press("2");
			sut.Press("5");
			sut.Press("=");
			//Assert
			Assert.AreEqual(37, sut.Display);

		}
	}
}
