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
    public class SalaryHourlyRate : SalaryBase
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
        /// Задание размера часовой тарифной ставки.
        /// </summary>
        public double HourlyRate
        {
            get
            {
                return _hourlyRate;
            }
            set 
            { 
                _hourlyRate = value; 
            }
        }

        /// <summary>
        /// Задание количества отработанных дней.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
            }
        }
        
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
