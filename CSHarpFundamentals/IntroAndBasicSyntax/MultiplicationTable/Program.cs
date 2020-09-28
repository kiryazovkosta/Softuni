using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var number);
            for (int multiBy = 1; multiBy <= 10; multiBy++)
            {
                Console.WriteLine($"{number} X {multiBy} = {number*multiBy}");
            }
        }
    }
}
