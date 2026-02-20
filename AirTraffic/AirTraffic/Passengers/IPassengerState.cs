using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic.Passengers
{
    public interface IPassengerState
    {
        void ReceiveDepartureNotification(Passenger passenger, string flightNumber, string destination);
        void ReceiveArrivalNotification(Passenger passenger, string flightNumber, string origin);
        void ReceiveDelayNotification(Passenger passenger, string flightNumber, int delayMinutes);
        string GetStateName();
    }
}
