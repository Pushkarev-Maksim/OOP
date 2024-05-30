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
                if (value < 0) 
                {
                    throw new ArgumentException("Тарифная ставка " +
                        "не может быть отрицательной!");
                }
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
                if (value < 0)
                {
                    throw new ArgumentException("Количество отработанных дней" +
                        "не может быть отрицательным!");
                }
                _days = value;
            }
        }

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
