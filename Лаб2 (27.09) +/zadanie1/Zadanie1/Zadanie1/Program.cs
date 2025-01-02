using System;

namespace aip
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("Для поиска локальных минимумов требуется ввести 3 и более элемента.");
                return;
            }

            Console.WriteLine("Введите элемент 1:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элемент 2:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 2; i < n; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}:");
                int a3 = Convert.ToInt32(Console.ReadLine());
               
                if (a1 > a2 && a2 < a3)
                {
                    result++;
                }

                a1 = a2;
                a2 = a3;
            }

            Console.WriteLine("Количество локальных минимумов равно " + result);
        }
    }
}