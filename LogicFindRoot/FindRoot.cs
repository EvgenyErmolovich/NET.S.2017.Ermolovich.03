using System;
namespace LogicFindRoot
{
	public static class FindRoot
	{
		public static double NewtonFormula(double number, int n, double eps)
		{
			ValidInput(number, n, eps);
			int count = 0;
			double temp = eps;
			while (temp < 1) 
			{
				temp *= 10;
				count++;
        	}
			double x1 = number / n;
			double x2 = 1.0 / n * ((n - 1) * x1 + number / Math.Pow(x1, n - 1));
            while (Math.Abs(x1 - x2) > eps) 
            {
                x1 = x2;
                x2 = 1.0 / n * ((n - 1) * x1 + number / Math.Pow(x1, n - 1));
            }
			return Math.Round(x2,count);
		}

		private static void ValidInput(double number, int n, double eps)
		{
			if (number <= 0 || n <= 0) throw new ArgumentException("Number must be > 0!");
			if (eps <= 0 || eps >= 1) throw new ArgumentOutOfRangeException("0 < eps < 1!");
		}
	}
}
