using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var sign = Sign(number);
            Console.WriteLine($"The number {number} is {sign}.");
        }

        private static string Sign(int number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number < 0)
            {
                return "negative";
            }

            return "zero";
        }
    }
}
