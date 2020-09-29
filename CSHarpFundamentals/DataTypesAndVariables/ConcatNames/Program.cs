namespace ConcatNames
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var delimiter = Console.ReadLine();
            Console.WriteLine($"{first}{delimiter}{second}");
        }
    }
}