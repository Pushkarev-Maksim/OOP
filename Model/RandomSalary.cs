﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для создания случайно заработной платы.
    /// </summary>
    public static class RandomSalary
    {
        /// <summary>
        /// Рандомайзер.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерация случайного числа double через int.
        /// </summary>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <returns>Сгенерированное число типа double.</returns>
        public static double GetRandomDouble(int minValue, int maxValue)
        {
            var randomValue = Convert.ToDouble(_random.Next(minValue, maxValue));
            return randomValue;
        }

        /// <summary>
        /// Генерация случайного числа int.
        /// </summary>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        /// <returns>Сгенерированное число типа int.</returns>
        public static int GetRandomInt(int minValue, int maxValue)
        {
            var randomValue = _random.Next(minValue, maxValue);
            return randomValue;
        }

        /// <summary>
        /// Генерация случайной зарплаты
        /// </summary>
        /// <returns></returns>
        public static SalaryBase GetRandomSalary()
        {
            var salaryType = GetRandomInt(0, 3);

            switch (salaryType)
            {
                case 0:
                {
                    return RandomSalaryHourlyRate();
                }
                case 1:
                {
                    return RandomSalaryMonthly();
                }
                default:
                {
                    return RandomSalaryTariffRate();
                }
            }
        }
        /// <summary>
        /// Генерация случайной часовой тарифной ставки.
        /// </summary>
        /// <returns>Параметры расчета зарплаты.</returns>
        public static SalaryBase RandomSalaryHourlyRate()
        {
            SalaryHourlyRate salaryHourlyRate = new SalaryHourlyRate
            {
                HourlyRate = GetRandomDouble(300, 1000),
                Hours = GetRandomInt(1, 100),
            };
            return salaryHourlyRate;
        }

        /// <summary>
        /// Генерация случайного оклада за месяц.
        /// </summary>
        /// <returns>Параметры расчета зарплаты.</returns>
        public static SalaryBase RandomSalaryMonthly()
        {
            SalaryMonthly salaryMonthly = new SalaryMonthly
            {
                FixedSalary = GetRandomDouble(5000, 100000),
                MonthlyWorkingDays = GetRandomInt(20, 31),
                ActualWorkedDays = GetRandomInt(1, 20),
            };
            return salaryMonthly;
        }

        /// <summary>
        /// Генерация случайной тарифной ставки.
        /// </summary>
        /// <returns>Параметры расчета зарплаты.</returns>
        public static SalaryBase RandomSalaryTariffRate()
        {
            SalaryTariffRate salaryTariffRate = new SalaryTariffRate
            {
                TariffRate = GetRandomDouble(500, 5000),
                Days = GetRandomInt(1, 100),
            };
            return salaryTariffRate;
        }
    }
}