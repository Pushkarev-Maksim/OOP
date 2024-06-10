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
            get { return _hourlyRate; }
            set 
            {
                CheckNegativeNumber(value, "Размер часовой тарифной ставки");
                _hourlyRate = value; 
            }
        }

        /// <summary>
        /// Задание количества отработанных часов.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                CheckNegativeNumber(value, "Количество отработанных часов");
                _hours = value;
            }
        }
        
        /// <summary>
        /// Вычисление заработной платы по часовой тарифной ставке.
        /// </summary>
        /// <returns></returns>
        public override double CalculateSalary => 
            Math.Round(HourlyRate * Hours, 2);

        /// <summary>
        /// Способ начисления зарплаты.
        /// </summary>
        public override string SalaryType => "Часовая тарифная ставка";

        /// <summary>
        /// Параметры для расчета зарплаты.
        /// </summary>
        public override string SalaryParameters
        {
            get
            {
                return $"Часовая тарифная ставка = {HourlyRate}, " +
                       $"Кол-во отработанных часов = {Hours}";
            }
        }
    }
}