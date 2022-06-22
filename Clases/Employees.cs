using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Clases
{
    public abstract class Employees : Person
    {
        private decimal salary;
        [DisplayName("Salario")]
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
        [DisplayName("Ingreso Local")]
        public DateTime IncomeScheduled { get; set; }
        [DisplayName("Ingreso Real")]
        public DateTime IncomeLocal { get; set; }
        [DisplayName("Tardia")]
        public DateTime IncomeLocalDelay { get; set; }
        [DisplayName("Ausencias")]
        public List<DateTime> Absences { get; set; }

        public Employees()
        {
            Salary = 0;
            IncomeScheduled = new DateTime();
            IncomeLocal = new DateTime();
            IncomeLocalDelay = new DateTime();
            IncomeLocalDelay = new DateTime();

            Name = "n/n";
            Surname = "n/n";
            BirthDay = new DateTime(1900,1,1);
            Telephono = 1000000000;
        }

        public Employees(string name_p, string surname_p, DateTime birthDay_p, int telephono_p, decimal salary_p, DateTime incomeScheduled_p, DateTime incomeLocal_p, DateTime incomeLocalDelay_p, DateTime absences_p)
        {
            Salary = salary_p;
            IncomeScheduled = incomeScheduled_p;
            IncomeLocal = incomeLocal_p;
            IncomeLocalDelay = incomeLocalDelay_p;
            IncomeLocalDelay = incomeLocalDelay_p;
            Absences.Add(absences_p);

            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;
        }

        public void Arrived()
        {
            CalculateDelay();
            if (IncomeLocalDelay.Minute < 5) IncomeLocalDelay = new DateTime();

            IncomeLocal = DateTime.Now;
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
