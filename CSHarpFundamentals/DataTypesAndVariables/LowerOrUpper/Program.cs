namespace LowerOrUpper
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            if (char.IsLower(symbol))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(symbol))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}