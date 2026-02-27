using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Cars.Asians
{
    public class AsianLuxuryCar : ICar
    {
        public string GetModel() => "Asian Executive Sedan";
        public double GetPrice() => 75000;
        public double GetAcceleration() => 5.0;
        public double GetTopSpeed() => 240;
        public double GetFuelConsumption() => 7.5;
        public string GetFuelType() => "Hybrid";
        public string GetChassisType() => "Advanced High-Strength Steel";

        public void DisplaySpecifications()
        {
            Console.WriteLine("Asian Luxury Car Specifications:");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: ${GetPrice()}");
            Console.WriteLine($"Acceleration (0-100 km/h): {GetAcceleration()} sec");
            Console.WriteLine($"Top Speed: {GetTopSpeed()} km/h");
        }
    }
}
