using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для оплаты по тарифной ставке.
    /// </summary>
    public class SallaryTariffRate : SalaryBase
    {
        /// <summary>
        /// Размер тарифной ставки.
        /// </summary>
        private double _tariffRate;

        /// <summary>
        /// Количество отработанных дней.
        /// </summary>
        private int _days;

        /// <summary>
        /// Вычисление заработной платы по тарифной ставке.
        /// </summary>
        /// <returns></returns>
        public override double SalaryCalculation()
        {
            return _tariffRate * _days;
        }
    }
}
