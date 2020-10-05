using System;

namespace ZigZagArrays
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            int[] first = new int[size];
            int[] second = new int[size];

            for (int lineIndex = 1; lineIndex <= size; lineIndex++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (lineIndex % 2 == 0)
                {
                    second[lineIndex - 1] = numbers[0];
                    first[lineIndex - 1] = numbers[1];
                }
                else
                {
                    second[lineIndex - 1] = numbers[1];
                    first[lineIndex - 1] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}