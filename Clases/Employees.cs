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
        protected decimal salary;
        [DisplayName("Salario")]
        protected decimal Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else salary = 0;
            }
        }
        
        protected List<DateTime> incomeLocal = new List<DateTime>();
        protected List<TimeSpan> incomeLocalDelay = new List<TimeSpan>();
        protected List<DateTime> absences = new List<DateTime>();

        public Employees()
        {
            this.Salary = 0;

            // Person
            Name = "";
            Surname = "";
            BirthDay = new DateTime();
            Telephono = 0;
        }
        public Employees(string name_p, string surname_p, DateTime birthDay_p, int telephono_p, decimal salary_p)
        {
            this.Salary = salary_p;
            
            // Persona
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;
        }
        public void Arrived()
        {
            incomeLocal.Add(DateTime.Now);
        }
        public void Absent()
        {
            absences.Add(DateTime.Now);
        }
        public void CalculateDelay()
        {
            incomeLocalDelay.Add(RemiseriaClass.Entrada - DateTime.Now);
        }
        public virtual void SetSalary(decimal salary_p)
        {
            // salario = sueldoNeto;
            Salary = salary_p;
        }
        public decimal GetSalary()
        {
            return Salary;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("LLegada: {0} Tardia: {1} Ausencias: {2}", incomeLocal, incomeLocalDelay, absences);
        }
    }
}
