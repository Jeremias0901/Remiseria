using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Car
    {
        public string Bland { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public char[] Patent { get; set; }
        private decimal costFuel;
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
        static public List<Car> Cars { get; set; }

        public Car(char[] patent_p, string bland_p = "", string model_p = "", string color_p = "", decimal costFuel_p = 0)
        {
            Bland = bland_p;
            Model = model_p;
            Color = color_p;
            Patent = new char[8];
            Patent = patent_p;
            costFuel = costFuel_p;
        }

        public Car(string bland_p = "", string model_p = "", string color_p = "", decimal costFuel_p = 0)
        {
            Bland = bland_p;
            Model = model_p;
            Color = color_p;
            Patent = new char [8];
            for (int i = 0; i < 8; i++)
                Patent[i] = '0';
            costFuel = costFuel_p;
        }

        public override string ToString()
        {
            return string.Format("Patente: {0} - Marca: {1} - Modelo: {2} - Color: {3}", Patent, Bland, Model, Color);
        }
    }
}
