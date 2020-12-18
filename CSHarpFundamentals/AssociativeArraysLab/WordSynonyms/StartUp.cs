namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            var wordsCount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int wordIndex = 0; wordIndex < wordsCount; wordIndex++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }

                words[word].Add(synonym);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}