using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Engines.Europeans
{
    public class EuropeanEconomyEngine : IEngine
    {
        public string GetEngineType() => "1.5L Turbocharged Inline-3";
        public double GetHorsepower() => 150;
        public double GetTorque() => 250;
        public double GetEmissionLevel() => 110;
        public double CalculatePerformance() => GetHorsepower() * GetTorque() / 1000;
        public string GetManufacturer() => "European Eco Engines";
    }
}
