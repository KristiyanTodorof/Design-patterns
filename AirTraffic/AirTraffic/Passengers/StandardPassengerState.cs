using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic.Passengers
{
    public class StandardPassengerState : IPassengerState
    {
        public string GetStateName()
        {
            return "Standard";
        }

        public void ReceiveArrivalNotification(Passenger passenger, string flightNumber, string origin)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Standard): Received basic notification that flight {flightNumber} from {origin} has arrived.");
        }

        public void ReceiveDelayNotification(Passenger passenger, string flightNumber, int delayMinutes)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Standard): Received basic notification that flight {flightNumber} is delayed by {delayMinutes} minutes.");
        }

        public void ReceiveDepartureNotification(Passenger passenger, string flightNumber, string destination)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Standard): Received basic notification that flight {flightNumber} to {destination} has departed.");
        }
    }
}
