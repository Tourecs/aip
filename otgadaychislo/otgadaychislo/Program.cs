using System;
namespace aip
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите количество операций:");
            int operationnum = Convert.ToInt32(Console.ReadLine());

            string[] operations = new string[operationnum]; // массив для хранения операций
            int[] constants = new int[operationnum]; // массив для хранения числовых значений
            bool[] ifusex = new bool[operationnum]; // массив для определения, используется ли X
            for (int i = 0; i < operationnum; i++) // сбор операций и их переменных
            {
                Console.WriteLine($"Операция { i + 1}. Введите арифметическую операцию (+, -, *)");
                string operation = Console.ReadLine(); // ввод операции
                Console.WriteLine("Введите число или переменную x:");
                string operand = Console.ReadLine(); // ввод числа или переменной x

                // если переменная равна x, мы отмечаем это в массиве ifusex и сохраняем операцию
                if (operand.ToLower() == "x")
                {
                    ifusex[i] = true;
                    operations[i] = operation;
                }
                // в противном случае, мы сохраняем значение в массиве constants, конвертируя  в целое число
                else
                {
                    ifusex[i] = false;
                    operations[i] = operation;
                    constants[i] = int.Parse(operand);
                }
            }
            double coefX = 1; // коэффицент для X
            double sumconstant = 0;   // сумма всех констант
            // обработка операций. Цикл проходит по всем введенным операциям, получая текущую операцию, константу и информацию о том, используется ли x
            for (int i = 0; i < operations.Length; i++)
            {
                string currentoperation = operations[i];
                int currentconstant = constants[i];
                bool usingX = ifusex[i];
                if (!usingX) // если операция с константой
                {
                    switch (currentoperation)
                    {
                        case "+":
                            sumconstant += currentconstant;
                            break;
                        case "-":
                            sumconstant -= currentconstant;
                            break;
                        case "*":
                            sumconstant *= currentconstant;
                            coefX *= currentconstant;
                            break;
                    }
                }
                else // если операция с X
                {
                    switch (currentoperation)
                    {
                        case "+":
                            coefX += 1; // добавление коэффицента для x
                            break;
                        case "-":
                            coefX -= 1; // вычитание коэффицента для x
                            break;
                    }
                }
            }
            Console.WriteLine("Введите желаемое значение:"); // запрашиваем у пользователя желаемое значение
            int value = Convert.ToInt32(Console.ReadLine());
            if (sumconstant == 0)  // проверяем возможные случаи для решения
            {
                if (sumconstant != value)
                {
                    Console.WriteLine("Нет решения");
                }
                else
                {
                    Console.WriteLine("Значение X может быть любым, так как уравнение выполняется:" + value);
                }
            }
            else
            {
                double resultX = (value - sumconstant) / coefX;
                Console.WriteLine("Значение X равно: " + resultX);
            }
        }
    }
}
