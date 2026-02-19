using CarFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryMethod.Factories
{
    public abstract class VehicleFactory
    {
        protected abstract IVehicle CreateVehicle();

        public void DeliverVehicle()
        {
            IVehicle vehicle = CreateVehicle();

            Console.WriteLine("Preparing vehicle for delivery...");
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();
            Console.WriteLine("Vehicle delivered!\n");
        }
    }
}
