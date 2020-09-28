using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var hours);
            int.TryParse(Console.ReadLine(), out var minutes);
            var initialDate = new DateTime(2000,1,1, hours, minutes, 0);
            var after30MinutesDateTime = initialDate.AddMinutes(30);
            Console.WriteLine($"{after30MinutesDateTime:H:mm}");
        }
    }
}
