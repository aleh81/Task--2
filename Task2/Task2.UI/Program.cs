﻿using System;
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
                Newton.CompareResult(9, 7, eps);
                Converter.BitConverter(10);
            }
            catch (Exception e)
            {
                System.Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }

            System.Console.ReadKey();
        }
    }
}
