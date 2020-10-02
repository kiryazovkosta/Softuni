namespace DayOfWeek
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var days = new string[]
            {
                "Monday",
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday", 
                "Sunday",
            };

            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            if (number <= 0 || number > days.GetLength(0))
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[number - 1]);
            }
        }
    }
}
