namespace SmallestOfThreeNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int b = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int c = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            int smallest = GetSmallestNumber(a, b, c);
            Console.WriteLine(smallest);
        }

        private static int GetSmallestNumber(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}