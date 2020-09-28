using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out var grade);
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
