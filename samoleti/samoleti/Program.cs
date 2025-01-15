using System;
namespace aip
        {class Airport
            {
                public string City {get; set;}
                public Airplane[] Airplanes {get; set;}
                public int AirplaneCount {get; private set;}

                public Airport(string city, int capacity)
                {
                    City = city;
                    Airplanes = new Airplane[capacity];
                    AirplaneCount = 0;
                }

                public void AddAirplane(Airplane airplane)
                {
                    if (AirplaneCount < Airplanes.Length)
                    {
                        Airplanes[AirplaneCount++] = airplane;
                    }
                    else
                    {
                        Console.WriteLine("Достигнуто максимальное количество самолетов в аэропорту");
                    }
                }
            }
    class Airplane
    {
        public string Departure {get; set;}
        public string Arrival {get; set;}
        public TimeSpan Duration {get; set;}
        public string Nameplane {get; set;}

        public Airplane(string departurecity, string arrivalcity, TimeSpan flightduration, string planename)
        {
            Departure = departurecity;
            Arrival = arrivalcity;
            Duration = flightduration;
            Nameplane = planename;
        }

        public override string ToString()
        {
            return $"Самолет: {Nameplane}, Город отправления: {Departure}, Город назначения: {Arrival}, Время в пути: {Duration}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное количество самолетов:");
            int maxAirplanes;
            while (!int.TryParse(Console.ReadLine(), out maxAirplanes) || maxAirplanes <= 0)
            {
                Console.WriteLine("Пожалуйста, введите корректное положительное число.");
            }

            Airport[] airports = new Airport[10];
            int airportCount = 0;

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Заполнение данных о городе и самолетах");
                Console.WriteLine("2. Выборка по городу назначения / типу самолета");
                Console.WriteLine("3. Выйти");
                Console.Write("Выберите пункт меню: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        // Заполнение данных о городе и самолётах
                        if (airportCount < airports.Length)
                        {
                            Console.Write("Введите название города: ");
                            string city = Console.ReadLine();
                            Airport airport = new Airport(city, maxAirplanes);

                            for (int i = 0; i < maxAirplanes; i++)
                            {
                                Console.WriteLine($"Введите данные о самолете {i + 1}: ");
                                Console.Write("Город отправления: ");
                                string departureCity = Console.ReadLine();
                                Console.Write("Город назначения: ");
                                string arrivalCity = Console.ReadLine();
                                Console.Write("Время в пути в формате часы:минуты: ");
                                string[] timeParts = Console.ReadLine().Split(':');

                                if (timeParts.Length != 2 ||
                                    !int.TryParse(timeParts[0], out int hours) ||
                                    !int.TryParse(timeParts[1], out int minutes) ||
                                    hours < 0 ||
                                    minutes < 0 ||
                                    minutes >= 60)
                                {
                                    Console.WriteLine("Некорректный ввод времени. Повторите попытку");
                                    i--;
                                    continue;
                                }

                                TimeSpan flightDuration = new TimeSpan(hours, minutes, 0);
                                Console.Write("Наименование самолета: ");
                                string airplaneName = Console.ReadLine();

                                airport.AddAirplane(new Airplane(departureCity, arrivalCity, flightDuration, airplaneName));
                            }

                            airports[airportCount++] = airport;
                            Console.WriteLine("Данные добавлены");
                        }
                        else
                        {
                            Console.WriteLine("Достигнуто максимальное количество аэропортов");
                        }
                        break;

                    case "2":
                        Console.Write("Введите город назначения или тип самолета для поиска: ");
                        string searchQuery = Console.ReadLine();
                        bool found = false;

                        foreach (var airport in airports)
                        {
                            if (airport != null)
                            {
                                foreach (var airplane in airport.Airplanes)
                                {
                                    if (airplane != null &&
                                        (airplane.Arrival.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                                        airplane.Nameplane.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)))
                                    {
                                        Console.WriteLine(airplane);
                                        found = true;
                                    }
                                }
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Самолеты не найдены");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Выход");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
