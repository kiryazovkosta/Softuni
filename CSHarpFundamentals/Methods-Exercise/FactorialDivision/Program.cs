namespace FactorialDivision
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int b = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            var factorialA = CalculateFactorial(a);
            var factorialB = CalculateFactorial(b);
            decimal divide = factorialA / factorialB;
            Console.WriteLine($"{divide:F2}");
        }

        private static decimal CalculateFactorial(int number)
        {
            decimal sum = 1m;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
