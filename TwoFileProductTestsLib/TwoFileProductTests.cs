using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoFilesProductLib;

namespace TwoFileProductTestsLib
{
	[TestClass]
	public class TwoFileProductTests
	{
		[TestMethod]
		public void Two_Rows_In_Each_File()
		{
			string input1 = "12.50\n17.50\n";
			string input2 = "2\n10\n";
			string expected = "12.50x2=25.00\n12.50x10=125.00\n17.50x2=35.00\n17.50x10=175.00\n";
			string output = TwoFilesProduct.Transform( input1, input2);
			Assert.AreEqual(expected, output);
		}
		[TestMethod]
		public void Two_Rows_Times_Three()
		{
			string input1 = "12.50\n17.50\n20.00\n";
			string input2 = "2\n10\n";
			string expected = "12.50x2=25.00\n12.50x10=125.00\n17.50x2=35.00\n17.50x10=175.00\n20.00x2=40.00\n20.00x10=200.00\n";
			string output = TwoFilesProduct.Transform(input1, input2);
			Assert.AreEqual(expected, output);
		}
	}
}
