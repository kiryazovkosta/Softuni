namespace SumоfChars
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                char symbol = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                sum += (int) symbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
