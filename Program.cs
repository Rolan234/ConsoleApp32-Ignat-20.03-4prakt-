using System;

namespace ConsoleApp32_Ignat_20._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 zadanie
            int[] array = new int[15];
            int positiveCount = 0, negativeCount = 0, zeroCount = 0;
                Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 11);
                Console.Write(array[i] + " Ответ ");
                if (array[i] > 0)
                {
                    positiveCount++;
                }
                else if (array[i] < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
                Console.WriteLine();
                Console.WriteLine($"Положительное кол-во элементов: { positiveCount}");
                Console.WriteLine($"Отрицательное кол-во элементов: {negativeCount}");
                Console.WriteLine($"Нулевое кол-во элементов: {zeroCount}");
                Console.Read();
            }


        }
    }
}
