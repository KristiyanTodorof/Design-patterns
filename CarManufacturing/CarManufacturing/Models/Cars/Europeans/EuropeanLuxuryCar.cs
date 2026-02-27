using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Cars.Europeans
{
    public class EuropeanLuxuryCar : ICar
    {
        public void DisplaySpecifications()
        {
            Console.WriteLine("European Luxury Car Specifications:");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: ${GetPrice()}");
            Console.WriteLine($"Acceleration (0-100 km/h): {GetAcceleration()} sec");
            Console.WriteLine($"Top Speed: {GetTopSpeed()} km/h");
        }

        public double GetAcceleration() => 4.5;


        public string GetChassisType() => "Aluminum Spaceframe";



        public double GetFuelConsumption() => 8.5;


        public string GetFuelType() => "Premium Gasoline";
        

        public string GetModel() => "European Luxury Sedan";


        public double GetPrice() => 85000;


        public double GetTopSpeed() => 250;
        
    }
}
