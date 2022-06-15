using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Customers : Person
    {
        public Customers(int code_p = 0, string name_p = "n/n", string surname_p = "n/n", DateTime birthDay_p = new DateTime(), int telephone_p = 100000)
        {
            Code = code_p;
            Name = name_p;
            Surname = surname_p;
            Telephone = telephone_p;
            BirthDay = birthDay_p;

            ListCustomers = new List<Customers>();
            ListTravels = new List<Travels>();
        }

        public int Code { set; get; }
        private static List<Travels> ListTravels { get; set; }
        private static List<Customers> ListCustomers { get; set; }
        
        public void OrderTravel(Travels travel)
        {
            ListTravels.Add(travel);
        }
        public override string ToString()
        {
            return string.Format("Codigo: {0} - Nombre: {1} - Apellido: {2} - Telefono: {3}", Code, Name, Surname, Telephone);
        }
        public static List<Travels> GetListTravel()
        {
            return ListTravels;
        }
        public static List<Customers> Find()
        {
            return ListCustomers;
        }
        public static Customers Find(int code_p)
        {
            Customers customer_result = new Customers();

            foreach (Customers c in ListCustomers)
            {
                if (c.Code == code_p)
                {
                    customer_result = c;
                    break;
                }
            }

            return customer_result;
        }
        public void Save()
        {
            ListCustomers.Add(this);
        }
        public void SaveTravel(Travels travel_p)
        {
            ListTravels.Add(travel_p);
        }
        public static int GenerateCode(Random rnd)
        {


            return rnd.Next(100000, 999999);
        }
    }
}
