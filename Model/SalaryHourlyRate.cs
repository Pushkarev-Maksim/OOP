using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для оплаты по часовой тарифной ставке.
    /// </summary>
    internal class SalaryHourlyRate : SalaryBase
    {
        /// <summary>
        /// Размер часовой тарифной ставки.
        /// </summary>
        private double _hourlyRate;

        /// <summary>
        /// Количество отработанных часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Вычисление заработной платы по часовой тарифной ставке.
        /// </summary>
        /// <returns></returns>
        public override double SalaryCalculation()
        {
            return _hourlyRate * _hours;
        }
    }
}
