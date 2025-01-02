using System;

namespace aip
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество значений:");
            int cycle = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int count = 0;

            Console.WriteLine("Введите значения:");
            for (int i = 0; i < cycle; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }
            }

            Console.WriteLine("Длина максимальной подпоследовательности четных чисел: " + max);
        }
    }
}