using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Cars.Asians
{
    public class AsianSportsCar : ICar
    {
        public string GetModel() => "Asian Performance Coupe";
        public double GetPrice() => 95000;
        public double GetAcceleration() => 3.8;
        public double GetTopSpeed() => 290;
        public double GetFuelConsumption() => 11.0;
        public string GetFuelType() => "Premium Gasoline";
        public string GetChassisType() => "Aluminum-Carbon Hybrid";

        public void DisplaySpecifications()
        {
            Console.WriteLine("Asian Sports Car Specifications:");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: ${GetPrice()}");
            Console.WriteLine($"Acceleration (0-100 km/h): {GetAcceleration()} sec");
            Console.WriteLine($"Top Speed: {GetTopSpeed()} km/h");
        }
    }
}
