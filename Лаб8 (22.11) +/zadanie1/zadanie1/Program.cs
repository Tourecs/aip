using System;
namespace aip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество подмассивов:");
            int arraynum = Convert.ToInt32(Console.ReadLine());
            int[][] jaggedarray = new int[arraynum][];

            for (int i = 0; i < arraynum; i++)
            {
                Console.WriteLine($"Введите количество элементов для подмассива номер {i + 1}:");
                int elnum = Convert.ToInt32(Console.ReadLine());
                jaggedarray[i] = new int[elnum];

                Console.WriteLine($"Введите {elnum} элементов для подмассива номер {i + 1} через пробел:");
                string[] input = Console.ReadLine().Split(' ');

                for (int k = 0; k < elnum; k++)
                {
                    jaggedarray[i][k] = Convert.ToInt32(input[k]);
                }
            }

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                int maxel = int.MinValue;
                int sum = 0;

                foreach (var number in jaggedarray[i])
                {
                    sum += number;
                    if (number > maxel)
                    {
                        maxel = number;
                    }
                }
                if (maxel > (sum - maxel))
                {
                    Console.WriteLine($"В массиве под номером {i + 1} максимальный элемент больше суммы остальных");
                }
            }
        }
    }
}
