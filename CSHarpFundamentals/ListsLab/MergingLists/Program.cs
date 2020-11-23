using System;

namespace MergingLists
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine()?.Split().Select(int.Parse).ToList();
            var second = Console.ReadLine()?.Split().Select(int.Parse).ToList();
            var result = new List<int>();
            var minCount = Math.Min(first.Count, second.Count);
            var maxCount = Math.Max(first.Count, second.Count);
            var index = 0;
            for (; index < minCount; index++)
            {
                result.Add(first[index]);
                result.Add(second[index]);
            }

            for (; index < maxCount; index++)
            {
                if (first.Count == maxCount)
                {
                    result.Add(first[index]);
                }
                else
                {
                    result.Add(second[index]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }


    }
}
