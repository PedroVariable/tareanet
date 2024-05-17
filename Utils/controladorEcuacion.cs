using System;

namespace ecuacionControlador.Utils
{
    public static class MathUtilities
    {
        public static double ComputeBinomialExpression(double a, double b, double x, double y, int n)
        {
            double sum = 0;
            for (int k = 0; k <= n; k++)
            {
                double binomialCoefficient = Factorial(n) / (Factorial(k) * Factorial(n - k));
                sum += binomialCoefficient * Math.Pow(a * x, n - k) * Math.Pow(b * y, k);
            }
            return sum;
        }

        public static double Factorial(int number)
        {
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
