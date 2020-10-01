namespace PrintPartOfASCIITable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int endIndex = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            for (int index = startIndex; index <= endIndex; index++)
            {
                Console.Write((char)index);
                if (index < endIndex)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
