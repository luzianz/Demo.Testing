using System;
using NUnit.Framework;

namespace Demo.Testing {

	[TestFixture]
	public class CalculatorTest {

		[TestCase(1, 1, 2)]
		[TestCase(10, 3, 13)]
		[TestCase(10, -1, 9)]
		[TestCase(1, -1, 0)]
		[TestCase(1, -3, -2)]
		public void Add(int a, int b, int expected) {
			var calculator = new Calculator();
			int result = calculator.Add(a, b);
			Assert.AreEqual(expected, result);
		}
	}
}