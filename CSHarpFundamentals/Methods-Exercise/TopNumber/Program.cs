namespace TopNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int i = 1; i <= number; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int number)
        {
            bool isTop = IsDivideBy8(number);
            if (isTop)
            {
                isTop = LeastOneOddDigit(number);
            }

            return isTop;
        }

        private static bool IsDivideBy8(int number)
        {
            int digitsSum = SumOfDigits(number);
            return digitsSum % 8 == 0;
        }

        private static bool LeastOneOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        private static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}
