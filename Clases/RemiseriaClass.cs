using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class RemiseriaClass
    {
        private decimal comition;
        public decimal Comition
        {
            get { return comition; }
            set
            {
                if ((value > 0) && (value <= 100)) comition = value;
                else comition = 0;
            }
        }
    }
}
