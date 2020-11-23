using System;

namespace GaussTrick
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var result = new List<int>();
            for (int i = 0, j = numbers.Count - 1; i <= numbers.Count / 2 && j > numbers.Count / 2; i++, j--)
            {
                if (i == numbers.Count / 2)
                {
                    result.Add(numbers[i]);
                }
                else
                {
                    result.Add(numbers[i] + numbers[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
