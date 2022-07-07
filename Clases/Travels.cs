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
        private string PlaceDeparture { get; set; }
        [DisplayName("Lugar Destino")]
        private string PlaceDestiny { get; set; }
        [DisplayName("Hora Partida")]
        private DateTime TimeDeparture { get; set; }
        [DisplayName("Hora Destino")]
        private DateTime TimeDestiny { get; set; }
        [DisplayName("Duracion")]
        private TimeSpan Duration { get; set; }
        [DisplayName("Demora")]
        private TimeSpan Delay { get; set; }
        [DisplayName("Estado")]
        private bool State { get; set; }
        [DisplayName("Coche")]
        private Car Car_o { get; set; }

        static public List<Travels> ListTravels = new List<Travels>();

        public Travels(string placeDeparture_p, string placeDestiny_p, TimeSpan duration_p, bool state_p, Car car_p)
        {
            PlaceDeparture = placeDeparture_p;
            PlaceDestiny = placeDestiny_p;
            Duration = duration_p;
            State = state_p;
            Car_o = car_p;
        }
        public Travels()
        {
            PlaceDeparture = "n/n";
            PlaceDestiny = "n/n";
            Duration = new TimeSpan();
            State = false;
            Car_o = new Car();

            TimeDeparture = DateTime.Now;
        }
        public void BeginTravel()
        {
            TimeDeparture = DateTime.Now;
        }
        public void Save()
        {
            ListTravels.Add(this);
        }
        public void FinishTravel()
        {
            TimeDestiny = DateTime.Now;
        }
        public void AddCar(Car car_p)
        {
            Car_o = car_p;
        }
        public override string ToString()
        {
            return string.Format("Lugar de Partida: {0} Lugar de Destino: {1} Hora de Partida: {2:t} Hora de Llegada: {3:t}", PlaceDeparture, PlaceDestiny, TimeDeparture, TimeDestiny);
        }
        public void CalculateDelay()
        {
            Delay = ViajeMenorDuracion() + ViajeMenorDuracion();
        }
        public TimeSpan ViajeMenorDuracion()
        {
            Travels ViajeMenor = ListTravels[0];

            for(int i = 1; i < ListTravels.Count; i++)
            {
                if(ViajeMenor.Delay < ListTravels[i].Delay)
                {
                    ViajeMenor = ListTravels[i];
                }
            }

            return ViajeMenor.Delay;
        }
    }
}
