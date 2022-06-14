using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Driver : Employees
    {
        private Car car;
        public Car Car
        {
            get { return car; }
            set
            {
                foreach (Car c in Car.Cars)
	            {
		            if(c.Equals(value))
                    {
                        car = value;
                    }
	            }
            }
        }
        public decimal Earnings { get; set; }
        public List<Travels> travels;
        public List<Customers> Customers;

        public void Earn(decimal monto)
        {
            Earnings += monto;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} - Apellido: {1} - Ganancias: {2} - Modelo de Auto: {3}  - Color de Auto: {4}", Name, Surname, Earnings, Car.Model, Car.Color);
        }
    }
}
