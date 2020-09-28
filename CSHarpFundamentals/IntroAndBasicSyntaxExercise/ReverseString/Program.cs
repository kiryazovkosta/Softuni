using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            char[] symbols = userInput?.ToCharArray();
            Array.Reverse(symbols);
            string reverseInput = new string(symbols);
            Console.WriteLine(reverseInput);
        }
    }
}
