using System;
namespace aip
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите количество фирм: ");
                int num = Convert.ToInt32(Console.ReadLine());
                double minprice = Int32.MaxValue;
                int companynum = 0;
                for (int i = 0; i < num; i++)
                {
                    // вводим значения для 2-х упаковок
                    string[] input = Console.ReadLine().Split(' ');
                    double x1 = Convert.ToDouble(input[0]);
                    double y1 = Convert.ToDouble(input[1]);
                    double z1 = Convert.ToDouble(input[2]);
                    double x2 = Convert.ToDouble(input[3]);
                    double y2 = Convert.ToDouble(input[4]);
                    double z2 = Convert.ToDouble(input[5]);
                    double c1 = Convert.ToDouble(input[6]);
                    double c2 = Convert.ToDouble(input[7]);

                    double v1 = x1 * y1 * z1; // объем 1й упаковки
                    double v2 = x2 * y2 * z2; // объем 2й упаковки

                    double s1 = (x1 * y1 + y1 * z1 + x1 * z1) * 2; // площадь 1 упаковки
                    double s2 = (x2 * y2 + y2 * z2 + x2 * z2) * 2; // площадь 2 упаковки

                    double pricelitr = (s1 * c2 - s2 * c1) / (v2 * s1 - s2 * v1) * 1000; // определяем минимальную стоимость упаковки молока
                    if (pricelitr < minprice)
                    {
                        minprice = pricelitr;
                        companynum = i + 1;
                    }
                }
                Console.WriteLine($"Номер фирмы: {companynum}, минимальная стоимость: {Math.Round(minprice, 2)}");
            }
        }
    }
