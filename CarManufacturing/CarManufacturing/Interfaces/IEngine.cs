using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Interfaces
{
    public interface IEngine
    {
        string GetEngineType(); 
        double GetHorsepower();
        double GetTorque();
        double GetEmissionLevel();
        double CalculatePerformance();
        string GetManufacturer();
    }
}
