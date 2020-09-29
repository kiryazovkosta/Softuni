using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char.TryParse(Console.ReadLine(), out char first);
            char.TryParse(Console.ReadLine(), out char second);
            char.TryParse(Console.ReadLine(), out char third);

            Console.WriteLine($"{third} {second} {first}");
        }
    }
}
