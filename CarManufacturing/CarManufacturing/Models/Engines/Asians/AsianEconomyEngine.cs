using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Engines.Asians
{
    public class AsianEconomyEngine : IEngine
    {
        public string GetEngineType() => "1.2L Hybrid Inline-4";
        public double GetHorsepower() => 100;
        public double GetTorque() => 200;
        public double GetEmissionLevel() => 90;
        public double CalculatePerformance() => GetHorsepower() * GetTorque() / 1000;
        public string GetManufacturer() => "Asian Green Mobility";
    }
}
