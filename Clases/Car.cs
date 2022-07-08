using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Clases
{
    public class Car
    {
        [DisplayName("Marca")]
        private string Bland { get; set; }
        [DisplayName("Modelo")]
        private string Model { get; set; }
        [DisplayName("Color")]
        private string Color { get; set; }
        [DisplayName("Patente")]
        private string Patent { get; set; }
        private decimal costFuel;
        [DisplayName("Costo Combustible")]
        public decimal CostFuel
        {
            get { return costFuel; }
            set { costFuel = (value > 0) ? value : 0; }
        }
        private bool Disponible { get; set; }

        private static List<Car> ListCars = new List<Car>();

        public Car(string patent_p, string bland_p, string model_p, string color_p, decimal costFuel_p)
        {
            Bland = bland_p;
            Model = model_p;
            Color = color_p;
            Patent = patent_p;
            CostFuel = costFuel_p;
            Disponible = true;
        }
        public Car()
        {
            Bland = "n/n";
            Model = "n/n";
            Color = "n/n";
            Patent = "AAA000";
            CostFuel = 0;
            Disponible = true;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Bland, Model, Color);
        }
        public void SaveCar()
        {
            ListCars.Add(this);
        }
        public void OcuparAuto()
        {
            Disponible = false;
        }
        public void DesocuparAuto()
        {
            Disponible = true;
        }
        static public List<Car> GetListCar()
        {
            return ListCars;
        }
        static public List<Car> GetFreeCars()
        {
            List<Car> freeCars = new List<Car>();

            foreach (Car c in ListCars)
            {
                if (c.Disponible)
                {
                    freeCars.Add(c);
                }
            }

            return freeCars;
        }
        static public Car Find(string patent_p)
        {
            Car c_result = new Car();

            foreach (Car car in ListCars)
            {
                if (car.Patent == patent_p)
                {
                    c_result = car;
                    break;
                }
            }

            return c_result;
        }
    }
}
