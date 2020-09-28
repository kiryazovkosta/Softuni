using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueReading = true;

            do
            {
                int.TryParse(Console.ReadLine(), out var number);
                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    continueReading = false;
                }

            } while (continueReading);
        }
    }
}
