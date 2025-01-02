using System;

namespace aip
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, -2, 0, 6, 7, 8, -1, 0 };
            int[] result = new int[numbers.Length];
            int addnum = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result[addnum++] = number;
                }
            }

            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    result[addnum++] = number;
                }
            }

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    result[addnum++] = number;
                }
            }
            bool ybivaet = true;
            if (numbers.Length > 1)
            {
                int diff = numbers[0] - numbers[1];
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] - numbers[i + 1] != diff)
                    {
                        ybivaet = false;
                        break;
                    }
                }
            }
            bool chet = true;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    chet = false;
                    break;
                }
            }

            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < addnum; i++)
            {
                Console.WriteLine(result[i]);
            }

            if (ybivaet)
            {
                Console.WriteLine("Массив является равномерно убывающим");
            }
            else
            {
                Console.WriteLine("Массив не является равномерно убывающим");
            }

            if (chet)
            {
                Console.WriteLine("Массив содержит и четные, и нечетные элементы");
            }
            else
            {
                Console.WriteLine("Массив содержит только четные элементы");
            }
        }
    }
}
    