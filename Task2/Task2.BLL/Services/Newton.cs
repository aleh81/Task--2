using System;

namespace Task2.BLL.Services
{
    public class Newton
    {
        private static double Pow(double a, int pow)
        {
            double result = 1;
            for (var i = 0; i < pow; i++) result *= a;

            return result;
        }

        private static double RecursionPow(double a, int pow)
        {
            return pow != 1 ? a * RecursionPow(a, --pow) : a;
        }

        private static double Sqrt(double num, int n, double eps)
        {
            double res = num;
            double prev = 0;
           
            while (Math.Abs(prev - res) >= eps)
            {
                prev = res;
                res = (1.0 / n) * ((n - 1) * res + num / (Pow(res, n - 1)));
            }

            return res;
        }

        private static double RecursionSqrt(double num, int n, double eps, double? startNum = null)
        {
            if (startNum == null)
            {
                startNum = num;
            }

            var prev = num;
            num = (1.0 / n) * ((n - 1) * num + startNum.Value / (RecursionPow(num, n - 1)));

            if (Math.Abs(prev - num) >= eps)
            {
                return RecursionSqrt(num, n, eps, startNum);
            }
            else
            {
                return num;
            }
        }

        public static void CompareResult(double number, int pow, double eps)
        {
            Console.WriteLine($"Math.Pow = {Math.Pow(number, 1.0 / pow): 0.00}");
            Console.WriteLine($"NewthonSqrt = {Sqrt(number, pow, eps): 0.00}");
            Console.WriteLine($"RecursionNewtonSqrt = {RecursionSqrt(number, pow, eps): 0.00}");
        }
    }
}
