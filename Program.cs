using System;

namespace ConsoleApp32_Ignat_20._03
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 2 zadanie
            double[] heights = { 150, 160, 165, 168, 180, 172, 160, 185, 174, 190 };
            double sumHeight = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sumHeight += heights[i];
            }
            double averageHeight = sumHeight / heights.Length;
            Console.WriteLine($"Средний рост студентов группы: {averageHeight}");
            Console.Read();
        }
    }
}
