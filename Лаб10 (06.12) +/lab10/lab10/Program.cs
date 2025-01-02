using System;
namespace aip
{
    class Program
    {
        public static void Main()
        {



            Construct a = new Construct(3, 0);
            a.Results();

            Construct b = new Construct(0, 1);
            b.Results();


            Construct c = new Construct(4, 8);
            c.Results();
        }
    }

    class Construct
    {
        public double x;
        public double y;


        public Construct()
        {
            x = 0;
            y = 0;
        }


        public Construct(double X)
        {
            x = X;
            y = 0;
        }


        public Construct(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public double sum()
        {
            return x + y;
        }


        public double raz()
        {
            return x - y;
        }


        public double proiz()
        {
            return x * y;
        }


        public double chast()
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return double.NaN;
            }
        }
        public void Results()
        {
            Console.WriteLine($"При x = {x}, y = {y}");
            Console.WriteLine($"Сумма: {sum()}");
            Console.WriteLine($"Разность: {raz()}");
            Console.WriteLine($"Произведение: {proiz()}");

            if (y != 0)
            {
                Console.WriteLine($"Частное: {chast()}");
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }

            Console.WriteLine();
        }
    }
}

