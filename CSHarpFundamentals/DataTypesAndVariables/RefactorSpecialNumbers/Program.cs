namespace RefactorSpecialNumbers
{
    using System;

    public class RefactorSpecialNumbersMain
    {
        public static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            for (int number = 1; number <= maxNumber; number++)
            {
                int currentNumber = number;
                int sumOfDigits = 0;
                bool isSpecial = false;

                while (currentNumber > 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber /= 10;
                }

                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{number} -> {isSpecial}");
            }

        }
    }
}
