namespace DayOfWeek
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}