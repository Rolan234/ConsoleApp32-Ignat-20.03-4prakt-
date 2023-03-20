using System;

namespace ConsoleApp32_Ignat_20._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 zadanie
            int[] array = { 1, 3, 4, 7, 10, 12, 14, 16, 18, 20, 23, 25 };
            int evenCount = 0;
            foreach ( int element in array)
            {
                if (element % 4 == 0) ;
                {
                    evenCount++;
                }
            }
            Console.WriteLine($"Количество четных элементов в массиве: {evenCount}");
            Console.Read();
            


        }
    }
}
