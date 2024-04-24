using System;

namespace projet
{
    class my_test
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введи значения n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum += (double)((i - 1)) * (i - 1) / (i - 1);
            }

            System.Console.WriteLine($"Сумма первых {n} членов: {sum}");
        }
    }
}