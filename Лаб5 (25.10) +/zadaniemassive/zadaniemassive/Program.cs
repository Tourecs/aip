using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите количество элементов массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                string[] array_string = new string[n];
                for (int i = 0; i < array_string.Length; i++)
                {
                    Console.WriteLine($"Введите элементы массива: {1 + i}");
                    array_string[i] = Console.ReadLine();
                }

                int[] array = new int[array_string.Length];
                for (int i = 0; i < array_string.Length; i++)
                {
                    array[i] = Convert.ToInt32(array_string[i]);
                }

                Console.WriteLine("Квадраты чисел массива:");
                for (int i = 0; i < array_string.Length; i++)
                {
                    int square = array[i] * array[i];
                    Console.WriteLine(square);
                }

            }
        }
    }
}