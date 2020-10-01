namespace BeerKegs
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            string biggestKegModel = string.Empty;
            double biggestKegVolume = 0;
            for (int kegIndex = 0; kegIndex < kegsNumber; kegIndex++)
            {
                string kegName = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                int kegHeight = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = kegName;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
