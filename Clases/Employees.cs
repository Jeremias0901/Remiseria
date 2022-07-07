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
        [DisplayName("Ingreso Real")]
        public DateTime IncomeLocal { get; set; }
        [DisplayName("Tardia")]
        public TimeSpan IncomeLocalDelay { get; set; }
        [DisplayName("Ausencias")]
        public List<DateTime> Absences { get; set; }
        
        public Employees()
        {
            Salary = 0;
            IncomeLocal = new DateTime();
            IncomeLocalDelay = new TimeSpan();

            Name = "n/n";
            Surname = "n/n";
            BirthDay = new DateTime(1900,1,1);
            Telephono = 1000000000;
        }

        public Employees(string name_p, string surname_p, DateTime birthDay_p, int telephono_p, decimal salary_p, DateTime incomeLocal_p, TimeSpan incomeLocalDelay_p, DateTime absences_p)
        {
            Salary = salary_p;
            IncomeLocal = incomeLocal_p;
            IncomeLocalDelay = incomeLocalDelay_p;
            Absences.Add(absences_p);

            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;
        }

        public void Arrived()
        {
            IncomeLocal = DateTime.Now;
            CalculateDelay();
        }

        public void CalculateDelay()
        {
            IncomeLocalDelay = RemiseriaClass.Entrada - DateTime.Now;
        }

        public virtual decimal ReceivesRemuneration()
        {
            return Salary;
        }
    }
}
