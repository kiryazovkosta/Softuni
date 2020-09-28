using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var n);
            int sum = 0;
            int counter = 0;
            int number = 1;
            do
            {
                Console.WriteLine(number);
                sum += number;
                number += 2;
                counter++;
            } while (counter < n);

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
