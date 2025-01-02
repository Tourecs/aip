using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            int n = 3;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (Math.Abs(a) % 10 == 2)
                {
                    res++;

                }

            }
            Console.WriteLine("Количество элементов заканчивающихся на 2: " + res);
        }
    }
}