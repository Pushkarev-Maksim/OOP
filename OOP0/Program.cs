/*Дана структура, задающая дату вида: Struct date {int day; int month;
int year;};
Пользуясь таким структурным типом, составить программу, определяющую:
дату следующего (относительно сегодняшнего) дня */

namespace OOP0
{
    using System;

    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Определение структуры DateОfDay.
        /// </summary>
        public struct DateОfDay
        {
            /// <summary>
            /// Определение переменной (поля) Day.
            /// </summary>
            public int Day;

            /// <summary>
            /// Определение переменной (поля) Month.
            /// </summary>
            public int Month;

            /// <summary>
            /// Определение переменной (поля) Year.
            /// </summary>
            public int Year;
        }

        /// <summary>
        /// Функция определение даты завтрашнего дня.
        /// </summary>
        /// <param name="date">Дата сегодняшнего дня.</param>
        /// <returns>Дату заданного дня.</returns>
        public static DateОfDay DateNextDay(DateОfDay date)
        {
            // Определяем количество дней в текущем месяце
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            // Если текущий день - последний день месяца
            if (date.Day == daysInMonth)
            {
                // Если текущий месяц - декабрь
                if (date.Month == 12)
                {
                    // Переходим на первый день января следующего года
                    date.Day = 1;
                    date.Month = 1;
                    date.Year++;
                }
                else
                {
                    // Переходим на первый день следующего месяца
                    date.Day = 1;
                    date.Month++;
                }
            }
            else
            {
                // Увеличиваем текущий день на 1
                date.Day++;
            }

            return date;
        }

        /// <summary>
        /// Функция, которая выводит в консоль дату завтрашнего дня.
        /// </summary>
        /// <param name="date">Дата завтрашнего дня.</param>
        public static void ConsoleOutput(DateОfDay date)
        {
            Console.WriteLine($"Дата завтрашнего дня: " +
                $"{date.Day}.{date.Month}.{date.Year}");
        }

        /// <summary>
        /// Функция заполнения структуры.
        /// </summary>
        /// <param name="day">День.</param>
        /// <param name="month">Месяц.</param>
        /// <param name="year">Год.</param>
        /// <returns>date.</returns>
        public static DateОfDay FillingTheStructure(int day, int month, int year)
        {
            // Создаем объект структуры
            DateОfDay date = default;

            // Заполняем объект структуры
            date.Day = day;
            date.Month = month;
            date.Year = year;

            // Возвращаем заполненный объект структуры
            return date;
        }

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            // С помощью функции FillingTheStructure заполним структуру
            DateОfDay date = FillingTheStructure(day, month, year);

            // Определяем дату завтрашнего дня с помощью функции DateNextDay
            DateОfDay dateNext = DateNextDay(date);

            // Выводим в консоль полученную дату с помощью функции ConsoleOutput
            ConsoleOutput(dateNext);
        }
    }
}