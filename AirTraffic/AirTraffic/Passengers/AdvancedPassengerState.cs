using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic.Passengers
{
    public class AdvancedPassengerState : IPassengerState
    {
        public string GetStateName()
        {
            return "Advanced";
        }

        public void ReceiveArrivalNotification(Passenger passenger, string flightNumber, string origin)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Advanced): Received detailed notification that flight {flightNumber} from {origin} has arrived at gate with luggage at belt 3.");
        }

        public void ReceiveDelayNotification(Passenger passenger, string flightNumber, int delayMinutes)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Advanced): Received detailed notification that flight {flightNumber} is delayed by {delayMinutes} minutes. New departure at {DateTime.Now.AddMinutes(delayMinutes).ToShortTimeString()}.");
        }

        public void ReceiveDepartureNotification(Passenger passenger, string flightNumber, string destination)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Advanced): Received detailed notification that flight {flightNumber} to {destination} has departed. Gate closing.");
        }
    }
}
