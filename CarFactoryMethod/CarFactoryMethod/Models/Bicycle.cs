using CarFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryMethod.Models
{
    public class Bicycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bicycle: Pedaling on the path.");
        }

        public void Start()
        {
            Console.WriteLine("Bicycle: Ready to go.");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle: Stopped.");
        }
    }
}
