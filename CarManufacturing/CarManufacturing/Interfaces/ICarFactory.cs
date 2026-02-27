using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Interfaces
{
    public interface ICarFactory
    {
        ICar CreateLuxuryCar();
        ICar CreateEconomyCar();
        ICar CreateSportsCar();
        IEngine CreateLuxuryEngine();
        IEngine CreateEconomyEngine();
        IEngine CreateSportsEngine();
        double CalculateProductionCost(ICar car);
        string GetRegionOfOrigin();
    }
}
