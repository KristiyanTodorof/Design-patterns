using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic
{
    public interface IAirTrafficMediator
    {
        void RegisterAircraft(Aircraft aircraft);
        void RegisterTower(Tower tower);
        void RegisterPassenger(Passenger passenger);
        void NotifyAboutDeparture(string flightNumber, string destination);
        void NotifyAboutArrival(string flightNumber, string origin);
        void NotifyAboutDelay(string flightNumber, int delayMinutes);
    }
}