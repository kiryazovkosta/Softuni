using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long.TryParse(Console.ReadLine(), out var maxNumber);

            for (int number = 1; number <= maxNumber; number++)
            {
                var currentNumber = number;
                var currentNumberDigitsSum = 0;
                while (currentNumber > 0)
                {
                    var digit = currentNumber % 10;
                    currentNumber /= 10;
                    currentNumberDigitsSum += digit;
                }

                bool isSpecial = (currentNumberDigitsSum == 5 || currentNumberDigitsSum == 7 || currentNumberDigitsSum == 11);

                Console.WriteLine($"{number} -> {isSpecial}");
            }
        }
    }
}
