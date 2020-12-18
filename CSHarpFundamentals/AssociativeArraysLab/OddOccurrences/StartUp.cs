namespace OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(s => s.ToLower())
                .ToList() ?? new List<string>();

            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, 0);
                }

                counts[word]++;
            }

            var oddTimes = counts.Where(count => count.Value % 2 != 0).Select(count => count.Key).ToList();
            Console.WriteLine(string.Join(" ", oddTimes));
        }
    }
}