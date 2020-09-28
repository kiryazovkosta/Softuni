using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var count);
            string type = Console.ReadLine()?.ToLower();
            string day = Console.ReadLine()?.ToLower();
            decimal personPrice = 0m;

            if (type == "students")
            {
                personPrice = day switch
                {
                    "friday" => 8.45m,
                    "saturday" => 9.8m,
                    "sunday" => 10.46m
                };
            }
            else if (type == "business")
            {
                personPrice = day switch
                {
                    "friday" => 10.9m,
                    "saturday" => 15.6m,
                    "sunday" => 16m
                };
            }
            else if (type == "regular")
            {
                personPrice = day switch
                {
                    "friday" => 15m,
                    "saturday" => 20m,
                    "sunday" => 22.5m
                };
            }

            var totalPrice = count * personPrice;
            if (type == "students" && count >= 30)
            {
                totalPrice *= 0.85m;
            }

            if (type == "business" && count >= 100)
            {
                totalPrice -= personPrice * 10m;
            }

            if (type == "regular" && (count >= 10 && count <= 20))
            {
                totalPrice *= 0.95m;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
