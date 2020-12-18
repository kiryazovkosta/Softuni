namespace Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers =
                Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .OrderByDescending(n => n)
                    .ToList()
                    .Take(3) ??
                new List<int>();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}