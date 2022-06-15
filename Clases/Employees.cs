using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Employees : Person
    {
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else salary = 0;
            }
        }
        public DateTime IncomeScheduled { get; set; }
        public DateTime IncomeLocal { get; set; }
        public DateTime IncomeLocalDelay { get; set; }
        public List<DateTime> Absences { get; set; }

        public Employees(decimal salary_p = 0, DateTime incomeScheduled_p = new DateTime(), DateTime incomeLocal_p = new DateTime(), DateTime incomeLocalDelay_p = new DateTime(), DateTime absences_p = new DateTime())
        {
            Salary = salary_p;
            IncomeScheduled = incomeScheduled_p;
            IncomeLocal = incomeLocal_p;
            IncomeLocalDelay = incomeLocalDelay_p;
            IncomeLocalDelay = incomeLocalDelay_p;
            Absences.Add(absences_p);
        }

        public void CalculateDelay()
        {
            IncomeLocalDelay = Convert.ToDateTime(IncomeScheduled - IncomeLocal);
        }

        public virtual decimal ReceivesRemuneration()
        {
            return Salary;
        }
    }
}
