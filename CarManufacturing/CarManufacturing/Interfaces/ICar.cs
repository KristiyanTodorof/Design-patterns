using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Interfaces
{
    public interface ICar
    {
        string GetModel();
        double GetPrice();
        double GetAcceleration();
        double GetTopSpeed();
        double GetFuelConsumption();
        string GetFuelType();
        string GetChassisType();
        void DisplaySpecifications();
    }
}
