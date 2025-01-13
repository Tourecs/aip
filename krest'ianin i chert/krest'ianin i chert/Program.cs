using System;
namespace aip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод: ");
            long input = Convert.ToInt32(Console.ReadLine());
            long count = 0;
            for (long n = 1; n <= input; n++)
            {
                for (long k = n + 1; k <= n * 2; k++)
                {
                    for (long z = 1; ; z++)
                    {
                        // вычисляем n * (2 ^ z) и k * ((2 ^ z) - 1)
                        long power = (long)Math.Pow(2, z);
                        if (n * power - k * (power - 1) < 0)
                        {
                            break; // если условие не выполняется, выходим из цикла
                        }
                        if (n * power - k * (power - 1) == 0)
                        {
                            count++;
                            break; // условие выполнено, выходим из цикла
                        }
                    }
                }
            }
            Console.WriteLine("Вывод: " + count);
        }
    }
}
