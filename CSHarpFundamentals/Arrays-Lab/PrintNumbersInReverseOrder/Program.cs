using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            int[] numbers = new int[size];
            for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                numbers[numberIndex] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            }

            for (int numberIndex = numbers.Length - 1; numberIndex >= 0; numberIndex--)
            {
                Console.Write(numbers[numberIndex]);
                if (numberIndex > 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
