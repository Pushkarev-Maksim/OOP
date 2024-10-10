using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Класс начисления заработной платы.
    /// </summary>
    [XmlInclude(typeof(SalaryHourlyRate))]
    [XmlInclude(typeof(SalaryMonthly))]
    [XmlInclude(typeof(SalaryTariffRate))]
    public abstract class SalaryBase
    {
        /// <summary>
        /// Способ начисления зарплаты.
        /// </summary>
        [DisplayName ("Способ начисления зарплаты")]
        public virtual string SalaryType { get; }

        /// <summary>
        /// Параметры для расчета зарплаты.
        /// </summary>
        [DisplayName ("Параметры для расчета зарплаты")]
        public virtual string SalaryParameters { get; }

        /// <summary>
        /// Вычисление зарплаты.
        /// </summary>
        [DisplayName ("Заработная плата, руб")]
        public abstract double CalculateSalary { get; }

        /// <summary>
        /// Проверка на отрицательные числа.
        /// </summary>
        /// <typeparam name="T">Размер ЗП или кол-во отработанных 
        /// дней и часов</typeparam>
        /// <param name="number"></param>
        /// <param name="name">Наименование параметра, который 
        /// необходимо проверить.</param>
        /// <returns>Размер ЗП или кол-во отработанных 
        /// дней и часов</returns>
        /// <exception cref="ArgumentException">Отрицательное число
        /// размера ЗП или кол-ва отработанных дней и часов</exception>
        public static T CheckNegativeNumber<T>(T number, string name) 
            where T : IComparable<T>
        {
            if (number.CompareTo(default) < 0 /* || double.IsNaN(number.CompareTo(default))*/)
            {
                throw new ArgumentException($"{name} " +
                    "не может быть отрицательным числом!");
            }
            return number;
        }
    }
}