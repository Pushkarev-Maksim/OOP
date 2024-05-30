using System;

namespace OOP1
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nВведите цифру, соответствующую способу " +
                    "начисления заработной платы:" +
                "\n1 - Почасовая тарифная ставка" +
                "\n2 - Оклад за месяц" +
                "\n3 - Тарифная ставка" +
                "\n4 - Выход");

                var inputSalary = Convert.ToInt32(Console.ReadLine());
                switch (inputSalary)
                {
                    case 1:
                        {
                            Console.WriteLine("\tОплата по окладу");
                            PrintWages(SumOfMonthSalary());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\tОплата по часовой " +
                                "тарифной ставке");
                            PrintWages(SumOfHourSalary());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\tОплата по тарифной " +
                                "ставке");
                            PrintWages(SumOfDaysSalary());
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Попробуйте еще раз");
                        }
                        break;
                }
            }
        }
    }
}