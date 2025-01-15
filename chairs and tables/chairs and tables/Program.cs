using System;
using System.Collections.Generic;

class Furniture
{
    public string Name {get; set;}
    public string City {get; set;}
    public decimal Price {get; set;}

    public Furniture(string name, string city, decimal price)
    {
        Name = name;
        City = city;
        Price = price;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Наименование: {Name}, Город производитель: {City}, Стоимость: {Price}");
    }
}
        class Tables : Furniture
        {
            public int Legnum {get; set;}
            public string Tabletype {get; set;}

            public Tables(string name, string city, decimal price, int legnum, string tabletype)
                : base(name, city, price)
            {
                Legnum = legnum;
                Tabletype = tabletype;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Колпчество ножек: {Legnum}, Тип столешницы: {Tabletype}");
            }
        }
class Chairs : Furniture
{
    public bool ifSoft {get; set;}
    public int Legnum {get; set;}

    public Chairs(string name, string city, decimal price, bool ifsoft, int legnum)
        : base(name, city, price)
    {
        ifSoft = ifsoft;
        Legnum = legnum;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Мягкий: {ifSoft}, Количество ножек равно {Legnum}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Furniture> furnitureList = new List<Furniture>();
        while (true)
        {
            Console.WriteLine("Меню: ");
            Console.WriteLine("1. Заполнить мебель и стулья");
            Console.WriteLine("2. Выборка по городу производителю");
            Console.WriteLine("3. Выборка по количеству ножек столов");
            Console.WriteLine("4. Выборка по количеству ножек стульев");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите пункт меню: ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Добавление новой мебели:");
                    Console.Write("Введите тип мебели (стул или стол): ");
                    string furnitureType = Console.ReadLine().ToLower();

                    Console.Write("Наименование: ");
                    string name = Console.ReadLine();
                    Console.Write("Город производитель: ");
                    string city = Console.ReadLine();
                    Console.Write("Стоимость: ");
                    decimal price;
                    while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
                    {
                        Console.Write("Введите корректную стоимость: ");
                    }

                    if (furnitureType == "стул")
                    {
                        Console.Write("Мягкий (да или нет): ");
                        bool isSoft = Console.ReadLine().ToLower() == "да";
                        Console.Write("Количество ножек: ");
                        int legCount;
                        while (!int.TryParse(Console.ReadLine(), out legCount) || legCount <= 0)
                        {
                            Console.Write("Введите корректное количество ножек: ");
                        }

                        Chairs chair = new Chairs(name, city, price, isSoft, legCount);
                        furnitureList.Add(chair);
                    }
                    else if (furnitureType == "стол")
                    {
                        Console.Write("Количество ножек: ");
                        int legCount;
                        while (!int.TryParse(Console.ReadLine(), out legCount) || legCount <= 0)
                        {
                            Console.Write("Введите корректное количество ножек: ");
                        }

                        Console.Write("Тип столешницы: ");
                        string tableTopType = Console.ReadLine();
                        Tables table = new Tables(name, city, price, legCount, tableTopType);
                        furnitureList.Add(table);
                    }
                    else
                    {
                        Console.WriteLine("Неверный тип мебели");
                    }

                    Console.WriteLine("Данные добавлены");
                    break;

                case "2":
                    Console.Write("Введите город производителя: ");
                    string searchCity = Console.ReadLine();
                    bool foundCity = false;

                    foreach (var furniture in furnitureList)
                    {
                        if (furniture.City.Equals(searchCity, StringComparison.OrdinalIgnoreCase))
                        {
                            furniture.DisplayInfo();
                            foundCity = true;
                        }
                    }

                    if (!foundCity)
                    {
                        Console.WriteLine("Мебель не найдена для указанного города");
                    }
                    break;

                case "3":
                    Console.Write("Введите количество ножек столов: ");
                    int searchLegCountTable;
                    while (!int.TryParse(Console.ReadLine(), out searchLegCountTable) || searchLegCountTable <= 0)
                    {
                        Console.Write("Введите корректное количество ножек: ");
                    }

                    bool foundTable = false;
                    foreach (var furniture in furnitureList)
                    {
                        if (furniture is Tables table && table.Legnum == searchLegCountTable)
                        {
                            table.DisplayInfo();
                            foundTable = true;
                        }
                    }

                    if (!foundTable)
                    {
                        Console.WriteLine("Столы с указанным количеством ножек не найдены");
                    }
                    break;

                case "4":
                    Console.Write("Введите количество ножек стульев: ");
                    int searchLegCountChair;
                    while (!int.TryParse(Console.ReadLine(), out searchLegCountChair) || searchLegCountChair <= 0)
                    {
                        Console.Write("Введите корректное количество ножек: ");
                    }

                    bool foundChair = false;
                    foreach (var furniture in furnitureList)
                    {
                        if (furniture is Chairs chair && chair.Legnum == searchLegCountChair)
                        {
                            chair.DisplayInfo();
                            foundChair = true;
                        }
                    }

                    if (!foundChair)
                    {
                        Console.WriteLine("Стулья с указанным количеством ножек не найдены");
                    }
                    break;

                case "5":
                    Console.WriteLine("Выход");
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Повторите попытку");
                    break;
            }
            Console.WriteLine();
        }
    }
}