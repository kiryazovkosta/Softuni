using System;

namespace RemoveNegativesАndReverse
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToList();
            numbers?.RemoveAll(n => n < 0);
            if (numbers?.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}