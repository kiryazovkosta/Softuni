using System;

namespace CommonElements
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] second = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int secondIndex = 0; secondIndex < second.Length; secondIndex++)
            {
                for (int firstIndex = 0; firstIndex < first.Length; firstIndex++)
                {
                    if (second[secondIndex] == first[firstIndex])
                    {
                        Console.Write($"{first[firstIndex]} ");
                    }
                }
            }
        }
    }
}
