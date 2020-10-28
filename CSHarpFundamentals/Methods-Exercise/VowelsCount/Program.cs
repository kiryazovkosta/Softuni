namespace VowelsCount
{
    using System;
    using System.Linq;

    class Program
    {
        private static readonly char[] vowelsLetters = new char[]{ 'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {
            var text = Console.ReadLine()?.ToLower();
            var count = CountVowels(text);
            Console.WriteLine(count);
        }

        private static int CountVowels(string text)
        {
            int count = 0;
            var letters = text.ToCharArray();
            foreach (var letter in letters)
            {
                if (vowelsLetters.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
    }
}