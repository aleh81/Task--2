using System;

namespace Task2.BLL.Services
{
    public class Newton
    {
        static double Pow(double a, int pow)
        {
            double result = 1;
            for (var i = 0; i < pow; i++) result *= a;

            return result;
        }

        public static double Sqrt(double num, int n, double eps)
        {
            if (eps >= 1) eps = 0.0000001;
            if (n < 2) return Double.NaN;
            if (n % 2 == 0 && num < 0) return Double.NaN;
            double res = num;
            double prev = 0;
            while (Math.Abs(prev - res) >= eps)
            {
                prev = res;
                res = (1.0 / n) * ((n - 1) * res + num / (Pow(res, n - 1)));
            }

            return res;
        }


        public static void CompareResult(double number, int pow, double eps)
        {
            Console.WriteLine($"Math.Pow = {Math.Pow(number, 1.0 / pow): 0.00}");
            Console.WriteLine($"NewthonSqrt = {Sqrt(number, pow, eps): 0.00} \n");
        }
    }
}
