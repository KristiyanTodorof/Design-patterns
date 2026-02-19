using CarFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryMethod.Models
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycle: Riding on the road.");
        }

        public void Start()
        {
            Console.WriteLine("Motorcycle: Engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle: Engine stopped.");
        }
    }
}
