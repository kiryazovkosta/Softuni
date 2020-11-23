using System;

namespace ListOfProducts
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var products = new List<string>();
            for (int pIndex = 0; pIndex < size; pIndex++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();
            for (int pIndex = 0; pIndex < products.Count; pIndex++)
            {
                Console.WriteLine($"{pIndex + 1}.{products[pIndex]}");
            }
        }
    }
}
