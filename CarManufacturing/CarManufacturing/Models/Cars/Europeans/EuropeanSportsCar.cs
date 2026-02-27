using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Cars.Europeans
{
    public class EuropeanSportsCar : ICar
    {
        public string GetModel() => "European Sports Coupe";
        public double GetPrice() => 120000;
        public double GetAcceleration() => 3.2;
        public double GetTopSpeed() => 320;
        public double GetFuelConsumption() => 12.5;
        public string GetFuelType() => "Racing Gasoline";
        public string GetChassisType() => "Carbon Fiber Composite";

        public void DisplaySpecifications()
        {
            Console.WriteLine("European Sports Car Specifications:");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: ${GetPrice()}");
            Console.WriteLine($"Acceleration (0-100 km/h): {GetAcceleration()} sec");
            Console.WriteLine($"Top Speed: {GetTopSpeed()} km/h");
        }
    }
}
