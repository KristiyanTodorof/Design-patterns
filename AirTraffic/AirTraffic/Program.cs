using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTraffic
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            IAirTrafficMediator airTrafficControl = new AirTrafficControl();

            Tower tower = new Tower(airTrafficControl);

            Aircraft flight1 = new Aircraft(airTrafficControl, "BA123", "Sofia", "London");
            Aircraft flight2 = new Aircraft(airTrafficControl, "FR456", "Varna", "Berlin");
            Aircraft flight3 = new Aircraft(airTrafficControl, "LH789", "Sofia", "Munich");

            Passenger standardPassenger = new Passenger(airTrafficControl, "Ivan", "BA123", 2);
            Passenger advancedPassenger = new Passenger(airTrafficControl, "Maria", "BA123", 7);
            Passenger premiumPassenger = new Passenger(airTrafficControl, "Peter", "FR456", 12);
            Passenger upgradingPassenger = new Passenger(airTrafficControl, "Dimitar", "LH789", 4);

            Console.WriteLine("\n=== SIMULATION ===\n");

            flight1.TakeOff();

            await Task.Delay(2000);

            flight2.TakeOff();

            await Task.Delay(2000);

            flight3.TakeOff();

            await Task.Delay(2000);

            flight1.Delay(30);

            await Task.Delay(2000);

            Console.WriteLine("\n--- LANDING SIMULATION ---");
            flight1.Land();

            await Task.Delay(2000);

            flight2.Land();

            await Task.Delay(2000);

            flight3.Land();

            Console.WriteLine("\n=== THE END ===");
        }
    }
}
