using System;
namespace aip
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, d;
            Console.WriteLine("Введите первое число:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((Math.Abs(c - d)) / 2.0) + (Math.Abs(c + d) / 2.0));

        }
    }
}