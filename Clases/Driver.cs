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
        [DisplayName("Auto")]
        private Car Car_a { get; set; }
        [DisplayName("Ganancias")]
        private decimal Earnings { get; set; }

        static private List<Driver> ListDrivers = new List<Driver>();

        public Driver()
        {
            this.Car_a = new Car();
            this.Earnings = 0;

            // Person
            Name = "";
            Surname = "";
            BirthDay = new DateTime();
            Telephono = 0;
            
            // Employee
            Salary = 0;
        }

        public Driver(string name_p, string surname_p, Car car_p, int telephono_p, decimal earnings_p, decimal salary_p, DateTime birthDay_p)
        {
            this.Car_a = car_p;
            this.Earnings = earnings_p;

            // Person
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;

            // Employee
            Salary = salary_p;
        }

        public void Earn(decimal monto)
        {
            Earnings += monto;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Auto: {0}, Ganacias: {1}", Car_a, Earnings);
        }
        public void AsignarAuto(Car car_p)
        {
            Car_a = car_p;
        }
        public void SaveDrivers()
        {
            ListDrivers.Add(this);
        }
        static public List<Driver> GetListDriver()
        {
            return ListDrivers;
        }
        static public List<Driver> GetAusentesDrivers()
        {
            List<Driver> lista_result = new List<Driver>();

            foreach (Driver d in ListDrivers)
            {
                if (d.incomeLocal.Count == 0)
                {
                    lista_result.Add(d);
                }
            }

            return lista_result;
        }
    }
}
