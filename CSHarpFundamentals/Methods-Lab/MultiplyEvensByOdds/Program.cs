using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(
                int.Parse(
                    Console.ReadLine() ?? throw new InvalidOperationException()));
            int multiple = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(multiple);
        }

        private static int GetMultipleOfEvenAndOdds(in int number)
        {
           int evenDigitsSum =  GetSumOfEvenDigits(number);
           int oddDigitsSum =  GetSumOfOddDigits(number);
           return evenDigitsSum * oddDigitsSum;
        }

        private static int GetSumOfOddDigits(in int number)
        {
            int counter = 0;
            int inputNumber = number;
            int sum = 0;
            while (inputNumber > 0)
            {
                int digit = inputNumber % 10;
                inputNumber /= 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                counter++;
            }

            return sum;
        }

        private static int GetSumOfEvenDigits(in int number)
        {
            int counter = 0;
            int inputNumber = number;
            int sum = 0;
            while (inputNumber > 0)
            {
                int digit = inputNumber % 10;
                inputNumber /= 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }

                counter++;
            }

            return sum;
        }
    }
}
