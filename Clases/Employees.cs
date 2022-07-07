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
        
        public List<DateTime> IncomeLocal = new List<DateTime>();
        public List<TimeSpan> IncomeLocalDelay = new List<TimeSpan>();
        public List<DateTime> Absences = new List<DateTime>();

        public Employees()
        {
            Salary = 0;
        }

        public Employees(string name_p, string surname_p, DateTime birthDay_p, int telephono_p, decimal salary_p)
        {
            Salary = salary_p;
            
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;
        }

        public void Arrived()
        {
            IncomeLocal.Add(DateTime.Now);
        }
        public void Absent()
        {
            Absences.Add(DateTime.Now);
        }
        public void CalculateDelay()
        {
            IncomeLocalDelay.Add(RemiseriaClass.Entrada - DateTime.Now);
        }

        public virtual decimal ReceivesRemuneration()
        {
            return Salary;
        }
    }
}
