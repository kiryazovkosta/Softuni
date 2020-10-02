using System;

namespace RoundingNumbers
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            if (numbers != null)
            {
                foreach (var number in numbers)
                {
                    double roundedNumber = Math.Round(number, MidpointRounding.AwayFromZero);
                    Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(roundedNumber)}");
                }
            }

        }
    }
}
