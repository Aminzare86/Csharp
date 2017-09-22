using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;
namespace MultiplierTestsLib
{
	[TestClass]
	public class MultiplierTests
	{
		[TestMethod]
		public void Simple()
		{
			// Arrange
			Multiplier myMultiplier = new Multiplier();
			// Act
			var actual = myMultiplier.Simple(20, 20);
			// Assert
			Assert.AreEqual(400, actual);
		}
		[TestMethod]
		public void While()
		{
			// Arrange
			Multiplier myMultiplier = new Multiplier();
			// Act
			var actual = myMultiplier.While(20, 20);
			// Assert
			Assert.AreEqual(400, actual);
		}
	}
}
