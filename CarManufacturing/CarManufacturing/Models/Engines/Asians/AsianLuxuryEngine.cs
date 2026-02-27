using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Engines.Asians
{
    public class AsianLuxuryEngine : IEngine
    {
        public string GetEngineType() => "3.5L Hybrid V6";
        public double GetHorsepower() => 380;
        public double GetTorque() => 550;
        public double GetEmissionLevel() => 120;
        public double CalculatePerformance() => GetHorsepower() * GetTorque() / 1000;
        public string GetManufacturer() => "Asian Hybrid Technologies";
    }
}
