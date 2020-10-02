namespace EvenAndOddSubtraction
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            long evenSum = 0;
            long oddSum = 0;

            for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                if (numbers[numberIndex] % 2 == 0)
                {
                    evenSum += numbers[numberIndex];
                }
                else
                {
                    oddSum += numbers[numberIndex];
                }
            }

            long difference = evenSum - oddSum;
            Console.WriteLine(difference);
        }
    }
}