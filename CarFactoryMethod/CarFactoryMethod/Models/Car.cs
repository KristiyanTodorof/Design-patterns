using CarFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryMethod.Models
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car: Driving on the road.");
        }

        public void Start()
        {
            Console.WriteLine("Car: Engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car: Engine stopped.");
        }
    }
}
