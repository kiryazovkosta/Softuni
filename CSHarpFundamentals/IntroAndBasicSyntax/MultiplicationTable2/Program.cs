using System;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var number);
            int.TryParse(Console.ReadLine(), out var beginMultiBy);
            if (beginMultiBy > 10)
            {
                Console.WriteLine($"{number} X {beginMultiBy} = {number * beginMultiBy}");
            }
            else
            {
                for (int multiBy = beginMultiBy; multiBy <= 10; multiBy++)
                {
                    Console.WriteLine($"{number} X {multiBy} = {number * multiBy}");
                }
            }
            
        }
    }
}
