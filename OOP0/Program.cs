using System;
using System.Collections.Generic;
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
                Console.WriteLine("Для выхода из программы нажмите \'x\'\n" +
                    "Для начала работы нажмите любую другую клавишу...");

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                Console.WriteLine();

                switch (userInput.KeyChar)
                {
                    case 'х':
                    case 'x':
                    case 'X':
                    case 'Х':
                        {
                            return;
                        }

                    default:
                        {
                            break;
                        }
                }

                SalaryBase motion = SalaryReader.ReadSalary();
                Console.WriteLine($"Размер зарплаты: " +
                    $"{Math.Round(motion.CalculateSalary(), 2)}\n");
            }
        }
    }
}