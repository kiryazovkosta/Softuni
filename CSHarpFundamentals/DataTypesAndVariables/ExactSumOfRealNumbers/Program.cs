using System;

namespace ExactSumOfRealNumbers
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int numbersSize);
            decimal numbersSum = 0m;
            for (int i = 0; i < numbersSize; i++)
            {
                decimal.TryParse(Console.ReadLine() ?? throw new InvalidOperationException(), out var number);
                numbersSum += number;
            }

            Console.WriteLine(numbersSum);
        }
    }
}
