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
            Name = "";
            Surname = "";
            BirthDay = new DateTime();
            Telephono = 0; 
            
            Car = new Car();
            Earnings = 0;
            ListTravels = new List<Travels>();

            Salary = 0;
            IncomeLocal = new DateTime();
            IncomeLocalDelay = new TimeSpan();

            Absences = new List<DateTime>();
        }

        public Driver(string name_p, string surname_p, Car car_p, int telephono_p, decimal earnings_p, decimal salary_p, DateTime incomeLocal_p, TimeSpan incomeLocalDelay_p, DateTime birthDay_p)
        {
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;

            Car = car_p;
            Earnings = earnings_p;

            Salary = salary_p; 
            IncomeLocal = incomeLocal_p;
            IncomeLocalDelay = incomeLocalDelay_p;

            Absences = new List<DateTime>();
        }

        [DisplayName("Auto")]
        public Car Car { get; set; }
        [DisplayName("Ganancias")]
        public decimal Earnings { get; set; }

        static private List<Travels> ListTravels = new List<Travels>();
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
        public void Absent()
        {
            this.Absences.Add(DateTime.Now);
        }
        public void AddTravel(Travels travel_p)
        {
            ListTravels.Add(travel_p);
        }
    }
}
