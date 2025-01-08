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
                Console.WriteLine("Количестество элементов должно быть больше нуля");
                return;
            }
            Console.WriteLine("Введите элемент номер 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            int max = 1;
            int temp = 1;

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine($"Введите элемент номер {i + 1}:");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b == a)
                {
                    temp += 1;
                }
                else
                {
                    if (max < temp)
                    {
                        max = temp;
                    }
                    temp = 1;
                }
                a = b;
            }

            if (max < temp)
            {
                max = temp;
            }

            Console.WriteLine($"Максимальная длина последовательных одинаковых равна {max}");
        }
    }
}