using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Engines.Europeans
{
    public class EuropeanLuxuryEngine : IEngine
    {
        public string GetEngineType() => "V12 Twin-Turbo";
        public double GetHorsepower() => 630;
        public double GetTorque() => 800;
        public double GetEmissionLevel() => 220;
        public double CalculatePerformance() => GetHorsepower() * GetTorque() / 1000;
        public string GetManufacturer() => "German Precision Engineering";
    }
}
