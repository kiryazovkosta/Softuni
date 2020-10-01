namespace IntegerOperations
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int b = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int c = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int d = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            long sum = a + b;
            sum /= c;
            sum *= d;
            Console.WriteLine(sum);
        }
    }
}
