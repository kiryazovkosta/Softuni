namespace Snowballs
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            var highestSnowballSnow = 0;
            var highestSnowballTime = 0;
            var highestSnowballQuantity = 0;
            BigInteger highestSnowballValue = 0;

            int snowballsNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int snowballIndex = 0; snowballIndex < snowballsNumber; snowballIndex++)
            {
                var snowballSnow = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                var snowballTime = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                var snowballQuantity = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuantity);
                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuantity = snowballQuantity;
                    highestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuantity})");
        }
    }
}
