using System;
using Model;

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
            Console.WriteLine("Для выхода из программы нажмите '1'\n" +
                    "Для начала работы нажмите '2'");

            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey(true);
                Console.WriteLine();

                switch (userInput.KeyChar)
                {
                    case '1':
                    {
                        return;
                    }

                    case '2':
                    {
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Введите 1 или 2!");
                        continue;
                    }
                }

                SalaryBase motion = SalaryReader.ReadSalary();
                Console.WriteLine($"Размер зарплаты: " +
                    $"{Math.Round(motion.CalculateSalary(), 2)}\n");
            }
        }
    }
}