using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Clases
{
    public abstract class Person
    {
        [DisplayName("Nombre")]
        protected string Name { get; set; }
        [DisplayName("Apellido")]
        protected string Surname { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        protected DateTime BirthDay { get; set; }
        private int telephono;
        [DisplayName("Telefono")]
        protected int Telephono
        {
            get { return telephono; }
            set { telephono = (value >= 1000000000) ? value : 0; }
        }

        public Person(string name_p, string surname_p, DateTime birthDay_p, int telephono_p)
        {
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephono = telephono_p;
        }
        public Person()
        {
            Name = "n/n";
            Surname = "n/n";
            BirthDay = new DateTime();
            Telephono = 0;
        }
        public bool BirthToday()
        {
            return DateTime.Equals(BirthDay, DateTime.Now);
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0} - Apellido: {1} - Telefono: {2}", Name, Surname, Telephono);
        }
    }
}
