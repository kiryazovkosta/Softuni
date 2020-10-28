using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetMiddleCharacters(text));
        }

        private static string GetMiddleCharacters(string text)
        {
            if (text.Length % 2 != 0)
            {
                Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                Console.Write($"{text[(text.Length / 2) - 1]}{text[text.Length / 2]}");
            }

            return string.Empty;
        }
    }
}
