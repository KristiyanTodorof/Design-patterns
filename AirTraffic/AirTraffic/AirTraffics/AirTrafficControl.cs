using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AirTraffic
{
    public class AirTrafficControl : IAirTrafficMediator
    {
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Tower _tower;
        private List<Passenger> _passengers = new List<Passenger>();
        public void NotifyAboutArrival(string flightNumber, string origin)
        {
            Console.WriteLine($"\n--- FLIGHT ARRIVAL ---");
            _tower.ReceiveArrivalNotification(flightNumber, origin);

            foreach (var passenger in this._passengers)
            {
                if(passenger.FlightNumber == flightNumber)
                {
                    passenger.ReceiveArrivalNotification(flightNumber, origin);
                }
            }
        }

        public void NotifyAboutDelay(string flightNumber, int delayMinutes)
        {
            Console.WriteLine($"\n--- FLIGHT DELAY ---");
            _tower.ReceiveDelayNotification(flightNumber, delayMinutes);

            foreach (var passenger in this._passengers)
            {
                if (passenger.FlightNumber == flightNumber)
                {
                    passenger.ReceiveDelayNotification(flightNumber, delayMinutes);
                }
            }
        }

        public void NotifyAboutDeparture(string flightNumber, string destination)
        {
            Console.WriteLine($"\n--- FLIGHT DEPARTURE ---");
            _tower.ReceiveDepartureNotification(flightNumber, destination);

            foreach (var passenger in this._passengers)
            {
                if (passenger.FlightNumber == flightNumber)
                {
                    passenger.ReceiveDepartureNotification(flightNumber, destination);
                }
            }
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            this._aircrafts.Add(aircraft);
            Console.WriteLine($"Aircraft {aircraft.FlightNumber} registered with ATC.");
        }

        public void RegisterPassenger(Passenger passenger)
        {
            this._passengers.Add(passenger);
            Console.WriteLine($"Passenger {passenger.Name} registered with ATC notifications.");
        }

        public void RegisterTower(Tower tower)
        {
            this._tower = tower;
            Console.WriteLine("Control tower registered with ATC.");
        }
    }
}
