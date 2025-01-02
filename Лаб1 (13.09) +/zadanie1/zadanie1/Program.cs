using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Получившиеся число a = {a - b} ");
            Console.WriteLine($"Получившиеся число b = {b - a} ");
        }

    }
}