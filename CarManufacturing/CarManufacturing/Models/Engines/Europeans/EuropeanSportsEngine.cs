using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Engines.Europeans
{
    public class EuropeanSportsEngine : IEngine
    {
        public string GetEngineType() => "4.0L V8 Twin-Turbo";
        public double GetHorsepower() => 550;
        public double GetTorque() => 700;
        public double GetEmissionLevel() => 190;
        public double CalculatePerformance() => GetHorsepower() * GetTorque() / 1000;
        public string GetManufacturer() => "European Performance Motors";
    }
}
