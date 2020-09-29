using System;

namespace Pounds2Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal.TryParse(Console.ReadLine(), out decimal pounds);
            decimal dollars = pounds * 1.31M;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
