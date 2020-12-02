namespace RandomizeWords
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var rnd = new Random();
            for (int i = 0; i < words?.Length; i++)
            {
                var randomIndex = rnd.Next(0, words.Length);

                var temp = words[i];
                var word = words[randomIndex];
                words[i] = word;
                words[randomIndex] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words ?? throw new InvalidOperationException()));
        }
    }
}