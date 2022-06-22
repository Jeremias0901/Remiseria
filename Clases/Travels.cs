using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Clases
{
    public class Travels
    {
        [DisplayName("Lugar Partida")]
        public string PlaceDeparture { get; set; }
        [DisplayName("Lugar Destino")]
        public string PlaceDestiny { get; set; }
        [DisplayName("Tiempo Partida")]
        public DateTime TimeDeparture { get; set; }
        [DisplayName("Tiempo Destino")]
        public DateTime TimeDestiny { get; set; }
        [DisplayName("Duracion")]
        public DateTime Duration { get; set; }
        [DisplayName("Demora")]
        public DateTime Delay { get; set; }
        [DisplayName("Estado")]
        public bool State { get; set; }

        public Travels(string placeDeparture_p, string placeDestiny_p, DateTime duration_p, bool state_p)
        {
            PlaceDeparture = placeDeparture_p;
            PlaceDestiny = placeDestiny_p;
            Duration = duration_p;
            State = state_p;
            
            TimeDeparture = DateTime.Now;
        }
        public Travels()
        {
            PlaceDeparture = "n/n";
            PlaceDestiny = "n/n";
            Duration = new DateTime();
            State = false;

            TimeDeparture = DateTime.Now;
        }

        public void SetTimeDestiny()
        {
            TimeDestiny = DateTime.Now;
        }
    }
}
