using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество строк:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, columns];
            for (int k = 0; k < rows; k++)
            {
                Console.WriteLine($"Массив данных номер { k + 1 }:");
                for (int m = 0; m < columns; m++)
                {

                    array[k, m] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                int max = 0;
                int min = 0;
                for (int j = 1; j < columns; j++)
                {
                    if (array[i, j] < array[i, min])
                    {
                        min = j;
                    }
                    if (array[i, j] > array[i, max])
                    {
                        max = j;
                    }

                }
                if (min != max)
                {
                    int temp = array[i, min];
                    array[i, min] = array[i, max];
                    array[i, max] = temp;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Массив номер {i + 1 } после перестановки максимального и минимального:");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);


                }
            }
        }
    }
}