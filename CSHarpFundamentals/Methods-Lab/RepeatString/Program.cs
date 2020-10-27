using System;

namespace RepeatString
{
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            int count = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            string result = RepeatString(pattern, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string pattern, int count)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                output.Append(pattern);
            }

            return output.ToString();
        }
    }
}
