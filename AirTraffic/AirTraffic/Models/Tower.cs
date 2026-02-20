using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic
{
    public class Tower : AirTrafficParticipant
    {
        public Tower(IAirTrafficMediator mediator) : base(mediator)
        {
            this._mediator.RegisterTower(this);
        }

        public void ReceiveDepartureNotification(string flightNumber, string destination)
        {
            Console.WriteLine($"Tower: Flight {flightNumber} has departed to {destination}. Monitoring airspace.");
        }

        public void ReceiveArrivalNotification(string flightNumber, string origin)
        {
            Console.WriteLine($"Tower: Flight {flightNumber} from {origin} has arrived safely. Clear from monitoring.");
        }

        public void ReceiveDelayNotification(string flightNumber, int delayMinutes)
        {
            Console.WriteLine($"Tower: Flight {flightNumber} has reported a delay of {delayMinutes} minutes. Adjusting schedule.");
        }
    }
}
