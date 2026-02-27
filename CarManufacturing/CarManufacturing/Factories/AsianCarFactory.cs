using CarManufacturing.Interfaces;
using CarManufacturing.Models.Cars.Asians;
using CarManufacturing.Models.Cars.Europeans;
using CarManufacturing.Models.Engines.Asians;
using CarManufacturing.Models.Engines.Europeans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Factories
{
    public class AsianCarFactory : ICarFactory
    {
        public ICar CreateLuxuryCar() => new AsianLuxuryCar();
        public ICar CreateEconomyCar() => new AsianEconomyCar();
        public ICar CreateSportsCar() => new AsianSportsCar();

        public IEngine CreateLuxuryEngine() => new AsianLuxuryEngine();
        public IEngine CreateEconomyEngine() => new AsianEconomyEngine();
        public IEngine CreateSportsEngine() => new AsiansSportsEngine();

        public double CalculateProductionCost(ICar car)
        {
            return car.GetPrice() * 0.5;
        }

        public string GetRegionOfOrigin() => "Asia";
    }
}
