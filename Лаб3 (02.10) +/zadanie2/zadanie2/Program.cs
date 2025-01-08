using System;
namespace aip
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Количестество элементов должно быть больше нуля");
                return;
            }
            Console.WriteLine("Введите элемент номер 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            int max = num;
            int k = 0;
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine($"Введите элемент номер {i + 1}:");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b % 2 == 0)
                {
                    k++;
                }
                else
                {
                    if (max > k)
                    {
                        max = k;
                    }
                    k = 0;
                }
                if (i == (num - 1))
                {
                    if (max > k)
                    {
                        max = b;
                    }
                    Console.WriteLine($"Наибольшее четное число равно {max}");
                }
            }
        }
    }
}
