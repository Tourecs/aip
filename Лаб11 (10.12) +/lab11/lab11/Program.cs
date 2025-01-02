using System;
namespace aip
{
    class Car
    {
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }

        public Car(string brand, string year, string color, string country)
        {
            Brand = brand;
            Year = year;
            Color = color;
            Country = country;
        }

        public override string ToString()
        {
            return $"Марка: {Brand}, Год: {Year}, Цвет: {Color}, Страна: {Country}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество машин:");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("Введите положительное число");
            }

            List<Car> cars = new List<Car>();

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("Выберите пункт от 1 до 4");
                Console.WriteLine("1. Создать машину");
                Console.WriteLine("2. Сортировать по году выпуска");
                Console.WriteLine("3. Сортировать по стране изготовителя");
                Console.WriteLine("4. Выход");

                int k;
                while (!int.TryParse(Console.ReadLine(), out k) || k < 1 || k > 4)
                    {
                        Console.WriteLine("Выберите пункт от 1 до 4");
                    }
                {
                    
                }

                switch (k)
                {
                    case 1:
                        if (cars.Count < num)
                        {
                            Console.WriteLine("Введите марку машины:");
                            string brand = Console.ReadLine();

                            Console.WriteLine("Введите год машины:");
                            string year = Console.ReadLine();

                            Console.WriteLine("Введите цвет:");
                            string color = Console.ReadLine();

                            Console.WriteLine("Введите страну-производитель:");
                            string country = Console.ReadLine();

                            cars.Add(new Car(brand, year, color, country));
                        }
                        else
                        {
                            Console.WriteLine("Количество машин в списке ограничено");
                        }
                        break;

                    case 2:
                        FilterByYear(cars);
                        break;

                    case 3:
                        FilterByCountry(cars);
                        break;

                    case 4:
                        Console.WriteLine("Выход");
                        return;
                }
            }
        }

        static void FilterByYear(List<Car> cars)
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("Введите год для выборки:");
                string yearchoice = Console.ReadLine();


                bool found = false;
                foreach (var car in cars)
                {
                    if (car.Year == yearchoice)
                    {
                        Console.WriteLine(car);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Не найдено машин произведенных в данный год");
                }
            }
            else
            {
                Console.WriteLine("В списке нет машин. Необходимо создать машину");
            }
        }

        static void FilterByCountry(System.Collections.Generic.List<Car> cars)
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("Введите страну для выборки:");
                string countrychoice = Console.ReadLine();

                bool found = false;
                foreach (var car in cars)
                {
                    if (car.Country.Equals(countrychoice, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(car);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Не найдено машин произведенных в данной стране");
                }
            }
            else
            {
                Console.WriteLine("В списке нет машин. Необходимо создать машину");
            }
        }
    }
}
