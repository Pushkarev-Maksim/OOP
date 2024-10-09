using System;
using Model;

namespace View
{
    internal class SalaryAddedEvent : EventArgs
    {
        public SalaryBase SalaryBase { get; }

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