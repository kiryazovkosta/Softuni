using System;

namespace AddAndSubtract
{
    using System.Threading.Channels;

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int b = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int c = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            int sum = Sum(a, b);
            sum = Subtrack(sum, c);
            Console.WriteLine(sum);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Subtrack(int a, int b)
        {
            return a - b;
        }
    }
}
