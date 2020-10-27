using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Print(number);
        }

        private static void Print(int number)
        {
            for (int index = 1; index <= number; index++)
            {
                PrintLine(1, index);
            }

            for (int index = number - 1; index >= 1; index--)
            {
                PrintLine(1, index);
            }
        }

        private static void PrintLine(int startIndex, int endIndex)
        {
            for (int index = startIndex; index <= endIndex; index++)
            {
                Console.Write($"{index} ");
            }

            Console.WriteLine();
        }

    }
}