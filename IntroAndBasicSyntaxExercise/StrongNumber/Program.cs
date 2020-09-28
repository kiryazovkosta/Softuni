namespace StrongNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var number);
            var originalNumber = number;

            long digitsFactoriesSum = 0;
            while (number >= 1)
            {
                var digit = number % 10;
                if (digit == 0)
                {
                    digitsFactoriesSum += 1;
                }
                else
                {
                    long digitsFactories = 1;
                    for (int i = 1; i <= digit; i++)
                    {
                        digitsFactories *= i;
                    }

                    digitsFactoriesSum += digitsFactories;
                }

                number /= 10;
            }

            Console.WriteLine(digitsFactoriesSum == originalNumber ? "yes" : "no");
        }
    }
}
