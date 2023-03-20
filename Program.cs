using System;

namespace ConsoleApp32_Ignat_20._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 zadanie 
            double[] mass = { 12.5, 20.3, 5.8, 8.7, 15.2 };
            double totalMass = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                totalMass += mass[i];
            }
            Console.WriteLine($"Общая масса груза: {totalMass}");
            Console.Read();
        }
    }
}
