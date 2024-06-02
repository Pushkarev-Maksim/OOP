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
    public class SalaryTariffRate : SalaryBase
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
        /// Задание размера тарифной ставки.
        /// </summary>
        public double TariffRate
        {
            get 
            {
                return _tariffRate; 
            }
            set
            {
                CheckNegativeNumber(value, "Размер тарифной ставки");
                _tariffRate = value;
            }
        }

        /// <summary>
        /// Задание количества отработанных дней.
        /// </summary>
        public int Days
        {
            get
            {
                return _days;
            }
            set
            {
                CheckNegativeNumber(value, "Количество отработанных дней");
                _days = value;
            }
        }

        /// <summary>
        /// Вычисление заработной платы по тарифной ставке.
        /// </summary>
        /// <returns></returns>
        public override double CalculateSalary()
        {
            return _tariffRate * _days;
        }
    }
}
