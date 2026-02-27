using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Engines.Asians
{
    public class AsiansSportsEngine : IEngine
    {
        public string GetEngineType() => "3.0L Twin-Turbo Inline-6";
        public double GetHorsepower() => 450;
        public double GetTorque() => 600;
        public double GetEmissionLevel() => 160;
        public double CalculatePerformance() => GetHorsepower() * GetTorque() / 1000;
        public string GetManufacturer() => "Asian Performance Dynamics";
    }
}
