using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var a);
            int.TryParse(Console.ReadLine(), out var b);
            int.TryParse(Console.ReadLine(), out var c);

            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
                if (b >= c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
                if (a >= c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(c);
                if (a >= b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
            }
        }
    }
}
