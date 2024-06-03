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
            while (true)
            {
                Console.WriteLine("Для выхода из программы нажмите '1'\n" +
                    "Для начала работы нажмите '2'");

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                Console.WriteLine();

                switch (userInput.KeyChar)
                {
                    case '1': 2
                        {
                            return;
                        }

                    case '2':
                        {
                            break;
                        }

                    default:
                        {
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