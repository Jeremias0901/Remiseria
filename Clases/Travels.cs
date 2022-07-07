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
        public Car Car_o { get; set; }

        public static List<Travels> ListTravels = new List<Travels>();

        public Travels(string placeDeparture_p, string placeDestiny_p, DateTime duration_p, bool state_p, Car car_p)
        {
            PlaceDeparture = placeDeparture_p;
            PlaceDestiny = placeDestiny_p;
            Duration = duration_p;
            State = state_p;
            Car_o = car_p;

            TimeDeparture = DateTime.Now;
        }
        public Travels()
        {
            PlaceDeparture = "n/n";
            PlaceDestiny = "n/n";
            Duration = new DateTime();
            State = false;
            Car_o = new Car();

            TimeDeparture = DateTime.Now;
        }

        public void Save()
        {
            ListTravels.Add(this);
        }
        
        public void SetTimeDestiny()
        {
            TimeDestiny = DateTime.Now;
        }

        public void AddCar(Car car_p)
        {
            Car_o = car_p;
        }
    }
}
