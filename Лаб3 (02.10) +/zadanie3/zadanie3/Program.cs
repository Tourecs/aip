using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Количество элементов должно быть больше нуля");
                return;
            }
            int max = 0;
            int temp = 0;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Введите элемент номер {i + 1}:");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b % 2 == 0)
                {
                    temp += b;
                }
                else
                {
                    if (temp > max)
                    {
                        max = temp;
                    }
                    temp = 0;
                }
            }
            if (temp > max)
            {
                max = temp;
            }

            Console.WriteLine($"Максимальная сумма четных чисел равна {max}");
        }
    }
}
