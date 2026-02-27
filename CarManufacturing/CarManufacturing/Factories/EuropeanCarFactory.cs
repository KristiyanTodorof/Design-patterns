using CarManufacturing.Interfaces;
using CarManufacturing.Models.Cars.Europeans;
using CarManufacturing.Models.Engines.Europeans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Factories
{
    public class EuropeanCarFactory : ICarFactory
    {
        public ICar CreateLuxuryCar() => new EuropeanLuxuryCar();
        public ICar CreateEconomyCar() => new EuropeanEconomyCar();
        public ICar CreateSportsCar() => new EuropeanSportsCar();

        public IEngine CreateLuxuryEngine() => new EuropeanLuxuryEngine();
        public IEngine CreateEconomyEngine() => new EuropeanLuxuryEngine();
        public IEngine CreateSportsEngine() => new EuropeanLuxuryEngine();

        public double CalculateProductionCost(ICar car)
        {
            return car.GetPrice() * 0.6;
        }

        public string GetRegionOfOrigin() => "Europe";
    }
}
