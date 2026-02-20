using AirTraffic.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic
{
    public class Passenger : AirTrafficParticipant
    {
        public string Name { get; private set; }
        public string FlightNumber { get; private set; }
        public int FlightCount { get; private set; }
        private IPassengerState _state;

        public Passenger(IAirTrafficMediator mediator, string name, string flightNumber, int flightCount = 0) : base(mediator)
        {
            this.Name = name;
            this.FlightNumber = flightNumber;
            this.FlightCount = flightCount;
            this._mediator.RegisterPassenger(this);
            UpdateState();

        }

        private void UpdateState()
        {
            if (this.FlightCount >= 10)
            {
                this._state = new PremiumPassengerState();
            }
            else if (FlightCount >= 5)
            {
                this._state = new AdvancedPassengerState();
            }
            else
            {
                this._state = new StandardPassengerState();
            }

            Console.WriteLine($"Passenger {this.Name} status: {this._state.GetStateName()} (Flights: {this.FlightCount})");
        }
        public void AddFlight()
        {
            this.FlightCount++;
            Console.WriteLine($"Passenger {Name} completed a new flight. Total flights: {FlightCount}");
            UpdateState();
        }

        public void ReceiveDepartureNotification(string flightNumber, string destination)
        {
            Console.WriteLine($"Passenger {this.Name}: Received notification that flight {flightNumber} to {destination} has departed.");
        }

        public void ReceiveArrivalNotification(string flightNumber, string origin)
        {
            Console.WriteLine($"Passenger {this.Name}: Received notification that flight {flightNumber} from {origin} has arrived.");
        }

        public void ReceiveDelayNotification(string flightNumber, int delayMinutes)
        {
            Console.WriteLine($"Passenger {this.Name}: Received notification that flight {flightNumber} is delayed by {delayMinutes} minutes.");
        }
    }
}
