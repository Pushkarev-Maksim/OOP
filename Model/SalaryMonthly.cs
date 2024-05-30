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
    internal class SalaryMonthly : SalaryBase
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
        /// Вычисление заработной платы по окладу за месяц.
        /// </summary>
        /// <returns></returns>
        public override double SalaryCalculation()
        {
            return _fixedSalary / _monthlyWorkingDays * _actualWorkedDays;
        }
    }
}
