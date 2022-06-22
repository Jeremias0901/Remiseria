using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Boss : Person
    {
        public void AddAbsences(Driver driver)
        {
            driver.Absences.Add(DateTime.Now);
        }
    }
}
