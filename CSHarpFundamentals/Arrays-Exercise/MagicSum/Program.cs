using System;

namespace MagicSum
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            long number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int numberIndex = 0; numberIndex < numbers.Length - 1; numberIndex++)
            {
                for (int subNumberIndex = numberIndex + 1; subNumberIndex < numbers.Length; subNumberIndex++)
                {
                    long sum = numbers[numberIndex] + numbers[subNumberIndex];
                    if (sum == number)
                    {
                        Console.WriteLine($"{numbers[numberIndex]} {numbers[subNumberIndex]}");
                    }
                }
            }
        }
    }
}
