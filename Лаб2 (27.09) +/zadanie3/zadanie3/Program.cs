using System;

namespace aip
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество введённых значений:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение 1:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение 2:");
            int b = Convert.ToInt32(Console.ReadLine());

            int max1 = Math.Max(a, b);
            int max2 = Math.Min(a, b);

            for (int i = 2; i < n; i++)
            {
                Console.WriteLine($"Введите значение {i + 1}: ");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c > max1)
                {
                    max2 = max1;
                    max1 = c;
                }
                else if (c > max2 && c != max1)
                {
                    max2 = c;
                }
            }

            Console.WriteLine("Второе максимальное значение: " + max2);
        }
    }
}