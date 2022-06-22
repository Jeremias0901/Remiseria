using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Clases
{
    public class Driver : Employees
    {
        public Driver()
        {
            Car = new Car();
            Earnings = 0;
            ListTravels = new List<Travels>();

            Name = "";
            Surname = "";
            BirthDay = new DateTime();
            Telephono = 0;

            Salary = 0;
            IncomeScheduled = new DateTime();
            IncomeLocal = new DateTime();
            IncomeLocalDelay = new DateTime();
            Absences = new List<DateTime>();

            // ListDrivers = new List<Driver>();
        }

        public Driver(string name_p, string surname_p, Car car_p, int telephono_p, decimal earnings_p, decimal salary_p, DateTime incomeScheduled_p, DateTime incomeLocal_p, DateTime incomeLocalDelay_p, DateTime absences_p, DateTime birthDay_p)
        {
            Car = car_p;
            Earnings = earnings_p;

            Salary = salary_p;
            IncomeScheduled = incomeScheduled_p;
            IncomeLocal = incomeLocal_p;
            IncomeLocalDelay = incomeLocalDelay_p;

            Absences = new List<DateTime>();
            Absences.Add(absences_p);

            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;
         
            // ListDrivers = new List<Driver>();
        }

        [DisplayName("Auto")]
        public Car Car { get; set; }
        [DisplayName("Ganancias")]
        public decimal Earnings { get; set; }

        static private List<Travels> ListTravels;
        static private List<Driver> ListDrivers = new List<Driver>();

        public void Earn(decimal monto)
        {
            Earnings += monto;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Surname);
        }

        public void AsignarAuto(Car car_p)
        {
            Car = car_p;
        }
        public void SaveDrivers()
        {
            ListDrivers.Add(this);
        }
        public static List<Driver> GetListDriver()
        {
            return ListDrivers;
        }
    }
}
