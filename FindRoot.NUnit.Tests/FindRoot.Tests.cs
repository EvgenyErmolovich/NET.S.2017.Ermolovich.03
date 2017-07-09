using NUnit.Framework;
using System;
namespace LogicFindRoot.NUnit.Tests
{
	[TestFixture()]
	public class FindRootTests
	{
		[TestCase(3, 2, 0.00001, ExpectedResult = 1.73205)]
		[TestCase(3, 2, 0.001, ExpectedResult = 1.732)]
		[TestCase(3, 2, 0.000001, ExpectedResult = 1.732051)]
		[TestCase(3, 2, 0.0000001, ExpectedResult = 1.7320508)]
		public double NewtonFormula_PositiveTests(double number, int n, double eps)
		{
			return FindRoot.NewtonFormula(number, n, eps);
		}

		[TestCase(3, -2, 0.0002)]
		[TestCase(-3, 2, 0.00002)]
		[TestCase(-3, -2, 0.00001)]
		public void NewTonFormula_ArgumentException(double number, int n, double eps)
		{
			Assert.Throws<ArgumentException>(() => FindRoot.NewtonFormula(number, n, eps));
		}

		[TestCase(3, 2, -0.0002)]
		[TestCase(3, 2, 1.00002)]
		public void NewTonFormula_ArgumentOutOfRangeException(double number, int n, double eps)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => FindRoot.NewtonFormula(number, n, eps));
		}
	}
}
