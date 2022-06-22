using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Clases
{
    public class Customers : Person
    {
        public Customers(int code_p, string name_p, string surname_p, DateTime birthDay_p, int telephone_p)
        {
            Code = code_p;
            Name = name_p;
            Surname = surname_p;
            Telephono = telephone_p;
            BirthDay = birthDay_p;

            ListTravels = new List<Travels>();
            ListCustomers = new List<Customers>();
        }
        public Customers()
        {
            Code = 0;
            Name = "n/n";
            Surname = "n/n";
            Telephono = 0;
            BirthDay = new DateTime();

            ListTravels = new List<Travels>();
            ListCustomers = new List<Customers>();
        }

        [DisplayName("Codigo")]
        public int Code { set; get; }
        private static List<Travels> ListTravels { get; set; }
        private static List<Customers> ListCustomers { get; set; }
        
        public void OrderTravel(Travels travel)
        {
            ListTravels.Add(travel);
        }
        public override string ToString()
        {
            return string.Format("Codigo: {0} - Nombre: {1} - Apellido: {2} - Telefono: {3}", Code, Name, Surname, Telephono);
        }
        public static List<Travels> GetListTravel()
        {
            return ListTravels;
        }
        public void SaveTravel(Travels travel_p)
        {
            ListTravels.Add(travel_p);
        }
        public static int GenerateCode(Random rnd)
        {
            return rnd.Next(100000, 999999);
        }
        public static Customers FindCustomer(int code_p)
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
        public void SaveCustomer()
        {
            ListCustomers.Add(this);
        }
        public static List<Customers> GetListCustomer()
        {
            return ListCustomers;
        }
    }
}
