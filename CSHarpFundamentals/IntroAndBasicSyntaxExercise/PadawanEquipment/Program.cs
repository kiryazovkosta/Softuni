namespace PadawanEquipment
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            decimal.TryParse(Console.ReadLine(), out var moneyAmount);
            int.TryParse(Console.ReadLine(), out var studentsCount);
            decimal.TryParse(Console.ReadLine(), out var sabersPrice);
            decimal.TryParse(Console.ReadLine(), out var robesPrice);
            decimal.TryParse(Console.ReadLine(), out var beltsPrice);

            var studentsCount10 = (Math.Round(((10.0m / 100) * studentsCount), MidpointRounding.ToPositiveInfinity));
            var freeBelts = studentsCount / 6;

            var totalAmount = (sabersPrice * (studentsCount + studentsCount10)) 
                              + (robesPrice * (studentsCount)) 
                              + (beltsPrice * (studentsCount - freeBelts));

            Console.WriteLine(moneyAmount < totalAmount
                ? $"Ivan Cho will need {totalAmount - moneyAmount:F2}lv more."
                : $"The money is enough - it would cost {totalAmount:F2}lv.");
        }
    }
}
