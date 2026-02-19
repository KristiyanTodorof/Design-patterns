using CarFactoryMethod.Interfaces;
using CarFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryMethod.Factories
{
    public class BicycleFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Bicycle();
        }
    }
}
