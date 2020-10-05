using System;

namespace KaminoFactory
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            string sequence = Console.ReadLine();

            while (sequence != null && !sequence.Equals("Clone them!"))
            {
                int[] currentDna = sequence.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentLength = 1;
                int bestCurrentLength = 1;
                int startCurrentIndex = 0;
                int currentDnsSum = 0;

                for (int dnaIndex = 0; dnaIndex < currentDna.Length - 1; dnaIndex++)
                {
                    if (currentDna[dnaIndex] == currentDna[dnaIndex + 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }

                    if (currentLength > bestCurrentLength)
                    {
                        bestCurrentLength = currentLength;
                        startCurrentIndex = dnaIndex;
                    }

                    currentDnsSum += currentDna[dnaIndex];
                }

                sequence = Console.ReadLine();
            }
        }
    }
}
