using System;

namespace aip
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество столбцов в массиве:");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов в столбце:");
            int row = int.Parse(Console.ReadLine());
            int[,] array = new int[column, row];

            // Ввод элементов массива
            for (int i = 0; i < column; i++)
            {
                Console.WriteLine($"Введите элементы столбца номер {i + 1}:");
                for (int j = 0; j < row; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            equalcolumn(array);
        }

        static void equalcolumn(int[,] array)
        {
            Console.WriteLine("Номера столбцов с одинаковыми элементами:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    bool equal = true;

                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[i, k] != array[j, k])
                        {
                            equal = false;
                            break;
                        }
                    }

                    if (equal)
                    {
                        Console.WriteLine($"{i + 1} и {j + 1}");
                    }
                }
            }
        }
    }
}
