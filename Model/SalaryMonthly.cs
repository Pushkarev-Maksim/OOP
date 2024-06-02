using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для оплаты по окладу за месяц
    /// </summary>
    public class SalaryMonthly : SalaryBase
    {
        /// <summary>
        /// Оклад за полный месяц.
        /// </summary>
        private double _fixedSalary;

        /// <summary>
        /// Количество рабочих дней в месяце.
        /// </summary>
        private int _monthlyWorkingDays;

        /// <summary>
        /// Количество фактически отработанных дней.
        /// </summary>
        private int _actualWorkedDays;

        /// <summary>
        /// Задание оклада за полный месяц.
        /// </summary>
        public double FixedSalary
        {
            get { return _fixedSalary; }
            set
            {
                CheckNegativeNumber(value, "Размер оклада за полный месяц");
                _fixedSalary = value;
            }
        }

        /// <summary>
        /// Задание количества рабочих дней в месяце.
        /// </summary>
        public int MonthlyWorkingDays
        {
            get { return _monthlyWorkingDays; }
            set
            {
                CheckNegativeNumber(value, "Количество рабочих дней в месяце");
                if (CheckDayInMonth(value))
                {
                    _monthlyWorkingDays = value;
                }
            }
        }

        /// <summary>
        /// Задание количества фактически отработанных дней
        /// в месяце.
        /// </summary>
        public int ActualWorkedDays
        {
            get { return _actualWorkedDays; }
            set
            {
                CheckNegativeNumber(value, "Количество фактически " +
                    "отработанных дней в месяце");
                if (CheckDayInMonth(value))
                {
                    _actualWorkedDays = value;
                }
            }
        }

        /// <summary>
        /// Проверка количества дней в месяце.
        /// </summary>
        /// <param name="value">Кол-во введенных дней.</param>
        /// <returns>true, если кол-во дней не больше 31,
        /// false - исключение.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Кол-во дней в
        /// месяце больше 31</exception>
        private bool CheckDayInMonth(int value)
        {
            if (value > 31)
            {
                throw new ArgumentException("Количество дней в месяце " +
                    "не может быть больше 31");
            }
            return true;
        }

        /// <summary>
        /// Вычисление заработной платы по окладу за месяц.
        /// </summary>
        /// <returns></returns>
        public override double CalculateSalary()
        {
            return _fixedSalary / _monthlyWorkingDays * _actualWorkedDays;
        }
    }
}