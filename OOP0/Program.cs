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
        /// Определение структуры Time.
        /// </summary>
        public struct Time
        {
            /// <summary>
            /// Определение переменной (поля) Сlock.
            /// </summary>
            public int Сlock;

            /// <summary>
            /// Определение переменной (поля) Minutes.
            /// </summary>
            public int Minutes;

            /// <summary>
            /// Определение переменной (поля) Seconds.
            /// </summary>
            public int Seconds;
        }

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
        /// Функция, которая выводит в консоль дату и время.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public static void ConsoleOutput1(DateОfDay date, Time time)
        {
            Console.WriteLine($"Дата и время: " +
                $"{date.Day}.{date.Month}.{date.Year}.{time.Сlock}.{time.Minutes}.{time.Seconds}");
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
        /// Функция заполнения структуры Time.
        /// </summary>
        /// <param name="сlock">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды</param>
        /// <returns>time.</returns>
        public static Time FillingTheStructure1(int сlock, int minutes, int seconds)
        {
            // Создаем объект структуры
            Time time = default;

            // Заполняем объект структуры
            time.Сlock = сlock;
            time.Minutes = minutes;
            time.Seconds = seconds;

            // Возвращаем заполненный объект структуры
            return time;
        }

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">.</param>
        public static void Main(string[] args)
        {
            // Ввод дня с консоли
            Console.WriteLine("Введите день: ");
            // Преобразование к типу int
            int day = int.Parse(Console.ReadLine());

            // Ввод месяца с консоли
            Console.WriteLine("Введите месяц: ");
            // Преобразование к типу int
            int month = int.Parse(Console.ReadLine());

            // Ввод года с консоли
            Console.WriteLine("Введите год: ");
            // Преобразование к типу int
            int year = int.Parse(Console.ReadLine());

            // Ввод часа с консоли
            Console.WriteLine("Введите часы: ");
            // Преобразование к типу int
            int сlock = int.Parse(Console.ReadLine());

            // Ввод минуты с консоли
            Console.WriteLine("Введите минуты: ");
            // Преобразование к типу int
            int minutes = int.Parse(Console.ReadLine());

            // Ввод секунды с консоли
            Console.WriteLine("Введите секунды: ");
            // Преобразование к типу int
            int seconds = int.Parse(Console.ReadLine());

            // С помощью функции FillingTheStructure заполним структуру
            DateОfDay date = FillingTheStructure(day, month, year);

            // С помощью функции FillingTheStructure1 заполним структуру
            Time time = FillingTheStructure1(сlock, minutes, seconds);

            // Определяем дату завтрашнего дня с помощью функции DateNextDay
            DateОfDay dateNext = DateNextDay(date);

            // Выводим в консоль дату и время
            ConsoleOutput1(date, time);

            // Выводим в консоль полученную дату с помощью функции ConsoleOutput
            ConsoleOutput(dateNext);
        }
    }
}