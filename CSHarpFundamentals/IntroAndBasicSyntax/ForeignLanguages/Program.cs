using System;

namespace ForeignLanguages
{
    using System.Threading.Channels;

    class Program
    {
        static void Main(string[] args)
        {
            var language = Console.ReadLine()?.ToLower();
            switch (language)
            {
                case "usa":
                case "england":
                    Console.WriteLine("English");
                    break;

                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
