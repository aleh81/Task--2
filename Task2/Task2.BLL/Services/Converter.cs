using System;

namespace Task2.BLL.Services
{
    public class Converter
    {
        public static void BitConverter(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("ERROR in Converter: number should be > 0");
            }

            Console.Write($"Bits of number : {number} :   ");

            for (var i = 0; i < 8; ++i)
            {
                Console.Write((number >> i) & 1);
            }
        }
    }
}
