namespace SumEvenNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            long sum = 0;
            for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                if (numbers[numberIndex] % 2 == 0)
                {
                    sum += numbers[numberIndex];
                }
            }

            Console.WriteLine(sum);
        }
    }
}