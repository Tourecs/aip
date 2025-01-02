using System;

namespace aip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            if (columns < 2)
            {
                Console.WriteLine("Для проверки равномерно убывающей последовательности необходимо не менее 2 столбцов");
                return;
            }

            int[,] array = new int[rows, columns];

            for (int k = 0; k < rows; k++)
            {
                Console.WriteLine($"Введите элементы для строки {k + 1}:");
                for (int m = 0; m < columns; m++)
                {
                    array[k, m] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int raznost = array[i, 0] - array[i, 1];
                bool ybivaet = true;

                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] <= array[i, j + 1] || array[i, j] - array[i, j + 1] != raznost)
                    {
                        ybivaet = false;
                        break;
                    }
                }

                if (ybivaet)
                {
                    Console.WriteLine($"Номер строки с равномерно убывающей последовательностью: {i + 1}");
                }
            }
        }
    }
}