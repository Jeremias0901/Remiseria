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
        [DisplayName("Codigo")]
        private int Code { set; get; }
        static private List<Customers> ListCustomers = new List<Customers>();

        public Customers(int code_p, string name_p, string surname_p, DateTime birthDay_p, int telephone_p)
        {
            this.Code = code_p;

            // Person
            Name = name_p;
            Surname = surname_p;
            Telephono = telephone_p;
            BirthDay = birthDay_p;
        }
        public Customers()
        {
            this.Code = 0;
            
            // Person
            Name = "n/n";
            Surname = "n/n";
            Telephono = 0;
            BirthDay = new DateTime();
        }
        public override string ToString() 
        {
            return base.ToString() + string.Format("Codigo: {0}", Code);
        }
        public void GenerateCode(Random rnd)
        {
            Code = rnd.Next(100000, 999999);
        }
        public void SaveCustomer()
        {
            ListCustomers.Add(this);
        }
        static public Customers FindCustomer(int code_p)
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
        static public List<Customers> GetListCustomer()
        {
            return ListCustomers;
        }
    }
}
