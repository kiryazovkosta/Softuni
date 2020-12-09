using System;

namespace AdvertisementMessage
{
    using System.Collections.Generic;

    public class Message
    {
        public string Phase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{this.Phase} {this.Event} {this.Author} - {this.City}";
        }
    }

    public class StartUp
    {
        private static string[] Phases = new[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        private static string[] Events = new[]
        {
            "Now I feel good.", 
            "I have succeeded with this product.", 
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", 
            "Try it yourself, I am very satisfied.", 
            "I feel great!"
        };

        private static string[] Authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        private static string[] Cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public static void Main()
        {
            var messages = new List<Message>();
            int messageSize = int.Parse(Console.ReadLine() ?? throw new InvalidProgramException());
            var random = new Random();
            for (int messageIndex = 1; messageIndex <= messageSize; messageIndex++)
            {
                messages.Add(new Message()
                {
                    Phase = Phases[random.Next(0, Phases.Length - 1)],
                    Event = Events[random.Next(0, Events.Length - 1)],
                    Author = Authors[random.Next(0, Authors.Length - 1)],
                    City = Cities[random.Next(0, Cities.Length - 1)]
                });
            }

            foreach (var message in messages)
            {
                Console.WriteLine(message.ToString());
            }
        }
    }
}
