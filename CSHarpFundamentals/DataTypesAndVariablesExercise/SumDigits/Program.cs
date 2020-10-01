namespace SumDigits
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            long number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            long digitsSum = 0;
            while (number > 0)
            {
                digitsSum += number % 10;
                number /= 10;
            }

            Console.WriteLine(digitsSum);
        }
    }
}
