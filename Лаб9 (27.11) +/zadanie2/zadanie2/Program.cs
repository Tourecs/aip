using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            string example = "aipaipaipaipaipaipaip";
            int minlength = 3;
            int maxlength = 0;

            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();

            int length = minlength;

            while (length <= input.Length)
            {
                string temp = input.Substring(0, length);
                if (example.Contains(temp))
                {
                    maxlength = length;
                    length++;
                }
                else
                {
                    input = input.Substring(length - 1);
                    length = minlength;
                }
            }

            Console.WriteLine("Максимальная равна " + maxlength);
        }
    }
}