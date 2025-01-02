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

            Nullable<int> minLength = null;

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                if (jaggedarray[i].Length < 2)
                    continue;


                int diff = jaggedarray[i][0] - jaggedarray[i][1];
                bool ybivaet = true;

                for (int k = 0; k < jaggedarray[i].Length - 1; k++)
                {
                    if (jaggedarray[i][k] - jaggedarray[i][k + 1] != diff)
                    {
                        ybivaet = false;
                        break;
                    }
                }


                if (ybivaet)
                {
                    int length = jaggedarray[i].Length;
                    Console.WriteLine($"Длина убывающего подмассива номер {i + 1} равна {length}");


                    if (minLength == null || length < minLength)
                    {
                        minLength = length;
                    }
                }
            }


            if (minLength != null)
            {
                Console.WriteLine($"Минимальная длина из всех подмассивов с равномерно убывающей последовательностью равна {minLength}");
            }
            else
            {
                Console.WriteLine("Не найдено подмассивов с убывающей последовательностью");
            }
        }
    }
}