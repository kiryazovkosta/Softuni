using System;

namespace SumAdjacentEqualNumbers
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            var numbers = userInput?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            for (int i = 0; i < numbers?.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers ?? throw new InvalidOperationException()));
        }
    }
}
