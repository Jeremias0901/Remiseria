using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Travels
    {
        public string PlaceDeparture { get; set; }
        public string PlaceDestiny { get; set; }
        public DateTime TimeDeparture { get; set; }
        public DateTime TimeDestiny { get; set; }
        public DateTime Duration { get; set; }
        public DateTime Delay { get; set; }
        public bool Estado { get; set; }

        public Travels(string placeDeparture_p = "", string placeDestiny_p = "", DateTime timeDeparture_p = new DateTime(), DateTime timeDestiny_p = new DateTime(), DateTime duration_p = new DateTime(), DateTime delay_p = new DateTime(), bool estado_p = false)
        {
            PlaceDeparture = placeDeparture_p;
            PlaceDestiny = placeDestiny_p;
            Duration = duration_p;
            Delay = delay_p;
            Estado = estado_p;
        }

        public void Duration_method()
        {

        }
    }
}
