using System;
namespace aip
{
    class Program
    {
        static void Main(){
            int n, l, m, p;
            Console.WriteLine("Введите число n: ");
            n = Convert.ToInt32(Console.ReadLine());
            l = 3;
            m = 3;
            p = 5;
            Console.WriteLine((p * 2 * n) + n * (l * 2 + m * 2) + (l * n - l) * n);

        }
    }
}