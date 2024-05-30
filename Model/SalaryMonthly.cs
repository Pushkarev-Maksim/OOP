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
        /// Количество рабочих дней месяце.
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
            get 
            { 
                return _fixedSalary; 
            }
            set
            {
                _fixedSalary = value;
            }
        }

        /// <summary>
        /// Задание количества рабочих дней в месяце.
        /// </summary>
        public int MonthlyWorkingDays
        {
            get
            {
                return _monthlyWorkingDays;
            }
            set
            {
                _monthlyWorkingDays = value;
            }
        }

        /// <summary>
        /// Задание количества фактически отработанных дней.
        /// </summary>
        public int ActualWorkedDays
        {
            get
            {
                return _actualWorkedDays;
            }
            set
            {
                _actualWorkedDays = value;
            }
        }

        /// <summary>
        /// Вычисление заработной платы по окладу за месяц.
        /// </summary>
        /// <returns></returns>
        public override double SalaryCalculation()
        {
            return _fixedSalary / _monthlyWorkingDays * _actualWorkedDays;
        }
    }
}
