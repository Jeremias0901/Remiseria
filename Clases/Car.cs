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
        public string Bland { get; set; }
        [DisplayName("Modelo")]
        public string Model { get; set; }
        [DisplayName("Color")]
        public string Color { get; set; }
        [DisplayName("Patente")]
        public string Patent { get; set; }
        private decimal costFuel;
        [DisplayName("Costo Combustible")]
        public decimal CostFuel
        {
            get { return costFuel; }
            set
            {
                if (value > 0)
                {
                    costFuel = value;
                }
                else costFuel = 0;
            }
        }
        
        private static List<Car> ListCars;


        public Car(string patent_p, string bland_p = "", string model_p = "", string color_p = "", decimal costFuel_p = 0)
        {
            Bland = bland_p;
            Model = model_p;
            Color = color_p;
            Patent = patent_p;
            costFuel = costFuel_p;

            ListCars = new List<Car>();
        }

        public Car()
        {
            Bland = "n/n";
            Model = "n/n";
            Color = "n/n";
            Patent = "AAA000";
            costFuel = 0;

            ListCars = new List<Car>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Bland, Model, Color);
        }

        public void SaveCar()
        {
            ListCars.Add(this);
        }
        public static List<Car> GetListCar()
        {
            return ListCars;
        }
    }
}
