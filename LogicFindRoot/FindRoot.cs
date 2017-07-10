using System;
namespace LogicFindRoot
{
	public static class FindRoot
	{
		/// <summary>
		/// Newtons formula of finding root.
		/// </summary>
		/// <returns>The root.</returns>
		/// <param name="number">Number.</param>
		/// <param name="n">Degree.</param>
		/// <param name="eps">Epselent.</param>
		public static double NewtonFormula(double number, int n, double eps)
		{
			ValidInput(number, n, eps);
			double x1 = number / n;
			double x2 = 1.0 / n * ((n - 1) * x1 + number / Math.Pow(x1, n - 1));
            while (Math.Abs(x1 - x2) > eps) 
            {
                x1 = x2;
                x2 = 1.0 / n * ((n - 1) * x1 + number / Math.Pow(x1, n - 1));
            }
			return x2;
		}
		/// <summary>
		/// Valids the input.
		/// </summary>
		/// <param name="number">Number.</param>
		/// <param name="n">Degree.</param>
		/// <param name="eps">Epsilent.</param>
		private static void ValidInput(double number, int n, double eps)
		{
			if ((number <= 0 && n % 2 == 0) || n <= 0) throw new ArgumentException("Number must be > 0!");
			if (eps <= 0 || eps >= 1) throw new ArgumentOutOfRangeException("0 < eps < 1!");
		}
	}
}
