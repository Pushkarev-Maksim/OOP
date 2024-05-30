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
        /// <returns></returns>
        public abstract double SalaryCalculation();
    }
}