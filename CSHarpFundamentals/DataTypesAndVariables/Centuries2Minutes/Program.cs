using System;

namespace Centuries2Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var centuries);

            int years = centuries * 100;
            long days = (long)(years * 365.2422m);
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
