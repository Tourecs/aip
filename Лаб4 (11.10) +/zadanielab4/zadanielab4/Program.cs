
using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            int result = 0;
            while (true)
            {
                Console.WriteLine("Введите значение:");
                int a = Convert.ToInt32(Console.ReadLine());
                while (a > 0)
                {
                    if (a % 10 % 2 == 0)
                    {
                        a /= 10;
                    }
                    else
                    {
                        result = result * 10 + a % 10;
                        a /= 10;
                    }
                }
                if (result == 0)
                {
                    Console.WriteLine("Введено четное значение");
                }
                else
                {
                    Console.WriteLine("Введено нечетное значение:" + result);

                    result = 0;
                }


            }
        }
    }
}