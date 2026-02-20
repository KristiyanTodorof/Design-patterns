using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AirTraffic
{
    public class Aircraft : AirTrafficParticipant
    {
        public string FlightNumber { get; set; }
        public string CurrentLocation { get; set; }
        public string Destination { get; set; }
        public bool IsDelayed { get; set; }
        public int DelayMinutes { get; set; }

        public Aircraft(IAirTrafficMediator mediator, string flightNumber, string currentLocation,
            string destination) : base(mediator)
        {
            this.FlightNumber = flightNumber;
            this.CurrentLocation = currentLocation;
            this.Destination = destination;
            this.IsDelayed = false;
            this.DelayMinutes = 0;

            this._mediator.RegisterAircraft(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.FlightNumber} is taking off from {this.CurrentLocation} to {this.Destination}");
            this._mediator.NotifyAboutDeparture(this.FlightNumber, this.Destination);
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.FlightNumber} is landing at {this.Destination} from {this.CurrentLocation}");
            string origin = this.CurrentLocation;
            this.CurrentLocation = this.Destination;
            this._mediator.NotifyAboutArrival(this.FlightNumber, origin);
        }

        public void Delay(int minutes)
        {
            this.IsDelayed = true;
            this.DelayMinutes = minutes;
            Console.WriteLine($"Aircraft {this.FlightNumber} is delayed by {minutes} minutes");
            this._mediator.NotifyAboutDelay(this.FlightNumber, minutes);
        }
    }
}
