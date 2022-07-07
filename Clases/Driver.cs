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
            
            Salary = 0;
        }

        public Driver(string name_p, string surname_p, Car car_p, int telephono_p, decimal earnings_p, decimal salary_p, DateTime birthDay_p)
        {
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;

            Car = car_p;
            Earnings = earnings_p;

            Salary = salary_p;
        }

        [DisplayName("Auto")]
        public Car Car { get; set; }
        [DisplayName("Ganancias")]
        public decimal Earnings { get; set; }

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
