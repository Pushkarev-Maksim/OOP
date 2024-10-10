using System;
using Model;

namespace View
{
    /// <summary>
    /// Класс отдает данные событию при добавлении
    /// новой ЗП.
    /// </summary>
    internal class SalaryAddedEvent : EventArgs
    {
        /// <summary>
        /// Свойство для получения добавленной ЗП.
        /// </summary>
        public SalaryBase SalaryBase { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="salaryBase">Добавленная ЗП.</param>
        /// <exception cref="ArgumentNullException">Проверка ЗП
        /// на null.</exception>
        public SalaryAddedEvent(SalaryBase salaryBase)
        {
            if (salaryBase == null)
            {
                throw new ArgumentNullException();
            }

            SalaryBase = salaryBase;
        }
    }
}