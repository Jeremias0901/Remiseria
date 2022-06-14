using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Customers : Person
    {
        public char[] Code;
        public DateTime OrderTime;
        public List<Travels> Travels;
        public static List<Customers> List;

        // empty
        public Customers()
        {
            Code = new char[6];
            for (int i = 0; i < 6; i++)
                Code[i] = '0';
            OrderTime = new DateTime(0,0,0);
            Name = "";
            Surname = "";
            BirthDay = new DateTime(0,0,0);
        }
        // full
        public Customers(char[] code_p, string name_p, string surname_p, DateTime birthDay_p)
        {
            Name = name_p;
            Surname = surname_p;
            BirthDay = birthDay_p;
            Code = code_p;
            OrderTime = DateTime.Now;
        }

        public void OrderTravel(Travels travel)
        {
            Travels.Add(travel);
        }

        public override string ToString()
        {
            return string.Format("Codigo: {0} - Nombre: {1} - Apellido: {2} - Telefono: {3}", Code, Name, Surname, Telephone);
        }
    }
}
