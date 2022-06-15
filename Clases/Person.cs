using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Person
    {
        public string Name {get; set;}
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        private int telephono;
        public int Telephone
        {
            get
            {
                return telephono;
            }
            set
            {
                if (value >= 1000000000)
                {
                    telephono = value;
                }
                else telephono = 0;
            }
        }

        public Person(string name_p = "", string surname_p = "", DateTime birthDay_p = new DateTime(), int telephono_p = 0)
        {
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Telephone = telephono_p;
        }

        public bool BirthToday()
        {
            return DateTime.Equals(BirthDay, DateTime.Now);
        }
    }
}
