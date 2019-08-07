using LakeMap.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LakeTest
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void GivenExampleTest()
		{
			string input = "####\r\n##O#\r\n#OO#\r\n####";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void NoLake()
		{
			string input = "####\r\n####\r\n####\r\n####";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void FullLake()
		{
			string input = "OOOO\r\nOOOO\r\nOOOO\r\nOOOO";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(16, result);
		}

		[TestMethod]
		public void CircleLake()
		{
			string input = "OOOO\r\nO##O\r\nO##O\r\nOOOO";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(12, result);
		}

		[TestMethod]
		public void CrossLake()
		{
			string input = "#OO#\r\nOOOO\r\n#OO#\r\n#OO#";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(10, result);
		}

		[TestMethod]
		public void DiagonalLake()
		{
			string input = "O###\r\nOO##\r\nOOO#\r\nOOOO";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(10, result);
		}

		[TestMethod]
		public void CrackedLake()
		{
			string input = "OOO#\r\nO#O#\r\nOO##\r\nOOOO";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);

			Assert.AreEqual(11, result);
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void NotSquareMapError()
		{
			string input = "O###\r\nOO##\r\nOOO#\r\nOOOO####################";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void OnlyOneLakeError()
		{
			string input = "O###\r\nO#O#\r\nOO##\r\nOOO#";
			var matrix = Utils.CreateMatrix(input);
			var result = Calculations.CalculateLakeArea(matrix);
		}
	}
}
