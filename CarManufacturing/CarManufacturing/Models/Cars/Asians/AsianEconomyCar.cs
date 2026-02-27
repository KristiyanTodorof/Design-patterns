using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Cars.Asians
{
    public class AsianEconomyCar : ICar
    {
        public string GetModel() => "Asian Compact City Car";
        public double GetPrice() => 18000;
        public double GetAcceleration() => 10.5;
        public double GetTopSpeed() => 160;
        public double GetFuelConsumption() => 4.8;
        public string GetFuelType() => "Electric/Hybrid";
        public string GetChassisType() => "Lightweight Unibody";

        public void DisplaySpecifications()
        {
            Console.WriteLine("Asian Economy Car Specifications:");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: ${GetPrice()}");
            Console.WriteLine($"Acceleration (0-100 km/h): {GetAcceleration()} sec");
            Console.WriteLine($"Top Speed: {GetTopSpeed()} km/h");
        }
    }
}
