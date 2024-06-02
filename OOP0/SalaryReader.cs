using System;
using System.Collections.Generic;
using Model;

namespace OOP1
{
    /// <summary>
    /// Класс чтения способа и параметров зачисления зарплаты.
    /// </summary>
    public class SalaryReader
    {
        /// <summary>
        /// Метод чтения способа начисления зарплаты с клавиатуры.
        /// </summary>
        /// <returns>Способ начисления зарплаты.</returns>
        /// <exception cref="ArgumentException">Неправильный выбор
        /// способа зачисления зарплаты.</exception>
        public static SalaryBase ReadSalary()
        {
            SalaryBase salary = new SalaryHourlyRate();

            var actions = new List<Action>()
            {
                () =>
                {
                    Console.WriteLine(
                        "Способы начисления зарплаты:\n" +
                        "1 - Часовая тарифная ставка\n" +
                        "2 - Оклад за месяц\n" +
                        "3 - Тарифная ставка\n" +
                        "Введите цифру из представленного списка:\n");
                },

                () =>
                {
                    int inputSalary = Convert.ToInt32(Console.ReadLine());
                    switch (inputSalary)
                    {
                        case 1:
                        {
                            Console.WriteLine("Расчет оплаты по часовой " +
                                "тарифной ставке: ");
                            salary = SalaryHourlyRate();
                            break;
                        }

                        case 2:
                        {
                            Console.WriteLine("Расчет оплаты по окладу " +
                                "за месяц: ");
                            salary = ReadSalaryMonthly();
                            break;
                        }

                        case 3:
                        {
                            Console.WriteLine("Расчет оплаты по тарифной " +
                                "ставке: ");
                            salary = ReadSalaryTariffRate();
                            break;
                        }

                        default:
                        {
                            throw new ArgumentException(
                                "\nВыберите способ начисления зарплаты " +
                                "из представленных на экране");
                        }
                    }
                },
            };

            ActionHandler(actions);

            return salary;
        }

        /// <summary>
        /// Метод чтения оплаты по часовой тарифной ставке.
        /// </summary>
        /// <returns>Часовая тарифная ставка.</returns>
        public static SalaryHourlyRate SalaryHourlyRate()
        {
            SalaryHourlyRate salaryHourlyRate = new SalaryHourlyRate();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите размер часовой тарифной ставки: ");
                    salaryHourlyRate.HourlyRate =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите количество отработанных часов: ");
                    salaryHourlyRate.Hours =
                        Convert.ToInt32(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return salaryHourlyRate;
        }

        /// <summary>
        /// Метод чтения оплаты по окладу за месяц.
        /// </summary>
        /// <returns>Оклад за месяц.</returns>
        public static SalaryMonthly ReadSalaryMonthly()
        {
            SalaryMonthly salaryMonthly = new SalaryMonthly();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите размер оклада за полный месяц: ");
                    salaryMonthly.FixedSalary =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите количество " +
                        "рабочих дней в месяце: ");
                    salaryMonthly.MonthlyWorkingDays =
                        Convert.ToInt32(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите количество фактически " +
                        "отработанных дней в месяце: ");
                    salaryMonthly.ActualWorkedDays =
                        Convert.ToInt32(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return salaryMonthly;
        }

        /// <summary>
        /// Метод чтения оплаты по тарифной ставке.
        /// </summary>
        /// <returns>Тарифная ставка.</returns>
        public static SalaryTariffRate ReadSalaryTariffRate()
        {
            SalaryTariffRate salaryTariffRate = new SalaryTariffRate();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите размер тарифной ставки: ");
                    salaryTariffRate.TariffRate =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите количество отработанных дней: ");
                    salaryTariffRate.Days =
                        Convert.ToInt32(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return salaryTariffRate;
        }

        /// <summary>
        /// Обработчик действий.
        /// </summary>
        /// <param name="actions">Действия для расчета зарплаты и
        /// действия в случае возникновения исключений.</param>
        private static void ActionHandler(List<Action> actions)
        {
            Dictionary<Type, Action<string>> catchDictionary =
                new Dictionary<Type, Action<string>>()
            {
                {
                    typeof(FormatException),
                    (string message) =>
                    {
                        Console.WriteLine($"Некорректный формат ввода");
                    }
                },
                {
                    typeof(ArgumentException),
                    Console.WriteLine
                },
            };

            foreach (var action in actions)
            {
                while (true)
                {
                    try
                    {
                        action.Invoke();
                        break;
                    }
                    catch (Exception exception)
                    {
                        catchDictionary[exception.GetType()].
                            Invoke(exception.Message);
                    }
                }
            }
        }
    }
}