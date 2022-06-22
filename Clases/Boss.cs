using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Boss : Person
    {
        public void CheckPresenceDrivers(Driver driver, bool present)
        {
            if(present)
            {
                driver.CalculateDelay();
                driver.IncomeLocal = DateTime.Now;
            }
            else
                driver.Absences.Add(DateTime.Now);
        }
    }
}
