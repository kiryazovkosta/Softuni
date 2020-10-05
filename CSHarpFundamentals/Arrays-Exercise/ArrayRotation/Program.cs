using System;

namespace ArrayRotation
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rotation = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int wordIndex = 0; wordIndex < rotation; wordIndex++)
            {
                string first = words[0];
                for (int subwordIndex = 0; subwordIndex < words.Length - 1; subwordIndex++)
                {
                    words[subwordIndex] = words[subwordIndex + 1];
                }

                words[^1] = first;
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
