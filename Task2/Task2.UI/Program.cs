using System;
using Task2.BLL.Services;

namespace Task2.UI
{
    class Program
    {
        const double eps = 0.00000001;

        static void Main(string[] args)
        {
            try
            {
                Newton.CompareResult(9, 3, eps);
                Console.WriteLine("-------------------------------");
                Converter.BitConverter(10);
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
