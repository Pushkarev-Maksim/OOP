using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс начисления заработной платы.
    /// </summary>
    public abstract class SalaryBase
    {
        /// <summary>
        /// Вычисление заработной платы.
        /// </summary>
        public abstract double CalculateSalary();

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
            if (number.CompareTo(default(T)) < 0)
            {
                throw new ArgumentException($"{name} " +
                    "не могут быть отрицательными числами!");
            }
            return number;
        }
    }
}