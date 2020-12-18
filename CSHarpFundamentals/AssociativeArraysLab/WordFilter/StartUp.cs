namespace WordFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()?
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Where(w => w.Length % 2 == 0)
                            .ToList() ??
                        new List<string>();
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}