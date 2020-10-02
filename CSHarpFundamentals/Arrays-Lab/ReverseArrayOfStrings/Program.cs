namespace ReverseArrayOfStrings
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string userInput = Console.ReadLine() ?? throw new InvalidOperationException();
            string[] words = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            for (int stringIndex = 0; stringIndex < words.Length; stringIndex++)
            {
                Console.Write(words[stringIndex]);
                if (stringIndex < words.Length - 1)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
