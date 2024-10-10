using System;
using System.ComponentModel;
using Model;

namespace View
{
    /// <summary>
    /// Класс отдает данные событию при фильтрации ЗП.
    /// </summary>
    internal class SalaryFilterEvent : EventArgs
    {
        /// <summary>
        /// Свойство для получения отфильтрованного списка.
        /// </summary>
        public BindingList<SalaryBase> FilteredSalaryList { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="filterTransportList">Отфильтрованный список
        /// ЗП.</param>
        /// <exception cref="ArgumentNullException">Проверка списка
        /// на null</exception>
        public SalaryFilterEvent(BindingList<SalaryBase>
            filterSalaryList)
        {
            if (filterSalaryList == null)
            {
                throw new ArgumentNullException();
            }

            FilteredSalaryList = filterSalaryList;
        }
    }
}