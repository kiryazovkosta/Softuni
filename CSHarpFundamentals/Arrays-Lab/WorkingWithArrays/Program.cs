using System;

namespace WorkingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3];
            array[0] = DateTime.Now;
            array[1] = 123;
            array[2] = "test";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
