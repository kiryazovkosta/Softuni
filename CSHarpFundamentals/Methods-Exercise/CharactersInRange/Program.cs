namespace CharactersInRange
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            char second = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            PrintCharsInASCIIRange(first, second);
        }

        private static void PrintCharsInASCIIRange(char first, char second)
        {
            if (first > second)
            {
                char temp = first;
                first = second;
                second = temp;
            }

            for (int i = first + 1; i < second; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
