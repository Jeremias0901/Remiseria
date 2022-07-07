using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class RemiseriaClass
    {
        public static DateTime Entrada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
        
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

        public void CambiarHorarioEntrada(DateTime horario)
        {
            Entrada = horario;
        }
    }
}
