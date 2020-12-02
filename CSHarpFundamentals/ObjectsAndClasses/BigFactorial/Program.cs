namespace BigFactorial
{
    using System;
    using System.Numerics;
    using System.Threading.Channels;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            BigInteger factorial = 1;
            for (int index = 2; index <= number; index++)
            {
                factorial *= index;
            }

            Console.WriteLine(factorial);
        }
    }
}
