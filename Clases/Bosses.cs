using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Bosses : Person
    {
        public List<Driver> Drivers;
        public List<Employees> Employees;
        public List<Car> Cars;

        public void CheckPresenceDrivers(Driver driver, bool present)
        {
            if(present)
                driver.CalculateDelay();
            else
                driver.Absences.Add(DateTime.Now);
        }
    }
}
