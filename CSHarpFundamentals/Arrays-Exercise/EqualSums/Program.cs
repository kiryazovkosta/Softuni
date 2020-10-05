using System;

namespace EqualSums
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

            bool noEqualSums = true;
            for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                long leftSum = 0;
                long rightSum = 0;

                for (int leftIndex = 0; leftIndex < numberIndex; leftIndex++)
                {
                    leftSum += numbers[leftIndex];
                }
                for (int rightIndex = numberIndex + 1; rightIndex < numbers.Length; rightIndex++)
                {
                    rightSum += numbers[rightIndex];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(numberIndex);
                    noEqualSums = false;
                    break;
                }
            }

            if (noEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
