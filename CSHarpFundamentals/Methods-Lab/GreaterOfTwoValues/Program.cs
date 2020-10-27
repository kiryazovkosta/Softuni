using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            //if (type == "int")
            //{
                
            //}
            string max = string.Compare(first, second, StringComparison.Ordinal) >= 0 ? first : second;
            Console.WriteLine(max);
        }
    }
}
