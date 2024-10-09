using System;
using System.ComponentModel;
using Model;

namespace View
{
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
        /// транспорта.</param>
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
