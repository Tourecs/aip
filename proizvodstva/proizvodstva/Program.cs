using System;
namespace aip
{
    class Program
    {
        static void Main()
        {
            DateTime startdate = GetDate("Введите дату начала производства (формат: dd.MM.yyyy): ");
            DateTime finishdate = GetDate("Введите дату конца производства (формат: dd.MM.yyyy): ");

            Console.WriteLine("Введите сколько продукции выпущено в первый день: ");
            int firstproduce = Convert.ToInt32(Console.ReadLine());

            int totalDays = (finishdate - startdate).Days; // находим разницу между концом и началом производства в днях

            // подсчёт результата
            int totalproduce = 0;
            for (int day = 0; day <= totalDays; day++)
            {
                totalproduce += firstproduce++;
            }

            // выводим отформатированные даты и суммарный объём продукции
            Console.WriteLine("Суммарный объём продукции: " + totalproduce);
        }

        static DateTime GetDate(string tip)
        {
            DateTime date;
            while (true)
            {
                Console.Write(tip);
                string input = Console.ReadLine();
                // проверка на правильный ввод даты
                if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    return date; // возвращаем корректную дату
                }
            }
        }
    }
}
