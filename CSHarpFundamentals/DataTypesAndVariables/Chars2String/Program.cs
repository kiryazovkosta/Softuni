using System;

namespace Chars2String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = new char[3];
            symbols[0] = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            symbols[1] = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            symbols[2] = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine(new string(symbols));
        }
    }
}
