using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            var totalPrice = CalculateTotalPrice(product, quantity);
            Console.WriteLine($"{totalPrice:F2}");
        }

        private static double CalculateTotalPrice(string product, int quantity)
        {
            var price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                        break;

                case "water":
                    price = 1.00;
                        break;

                case "coke":
                     price = 1.40;
                     break;

                case "snacks":
                    price = 2.00;
                    break;
                
                default:
                    break;
            }

            return quantity * price;
        }
    }
}
