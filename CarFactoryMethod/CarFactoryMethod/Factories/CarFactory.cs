using CarFactoryMethod.Interfaces;
using CarFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryMethod.Factories
{
    public class CarFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
