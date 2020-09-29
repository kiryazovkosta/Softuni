using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            short area = short.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
