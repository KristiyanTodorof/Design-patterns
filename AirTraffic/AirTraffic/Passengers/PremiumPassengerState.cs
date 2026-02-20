using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic.Passengers
{
    public class PremiumPassengerState : IPassengerState
    {
        public void ReceiveDepartureNotification(Passenger passenger, string flightNumber, string destination)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Premium): Received VIP notification that flight {flightNumber} to {destination} has departed. We hope you are enjoying the lounge access and priority boarding.");
        }

        public void ReceiveArrivalNotification(Passenger passenger, string flightNumber, string origin)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Premium): Received VIP notification that flight {flightNumber} from {origin} has arrived. A personal assistant will help with your luggage at belt 1.");
        }

        public void ReceiveDelayNotification(Passenger passenger, string flightNumber, int delayMinutes)
        {
            Console.WriteLine($"Passenger {passenger.Name} (Premium): Received VIP notification that flight {flightNumber} is delayed by {delayMinutes} minutes. Please accept our apologies, a compensation voucher has been issued. Your new departure time is {DateTime.Now.AddMinutes(delayMinutes).ToShortTimeString()}.");
        }

        public string GetStateName()
        {
            return "Premium";
        }
    }
}
