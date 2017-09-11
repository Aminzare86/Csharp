using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestLip
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//Arrangé
			MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
			//Act
			var actual = myMultiplier.Simple(20, 20);
			//Assert
			Assert.AreEqual(400, actual);
		}
	}
}
