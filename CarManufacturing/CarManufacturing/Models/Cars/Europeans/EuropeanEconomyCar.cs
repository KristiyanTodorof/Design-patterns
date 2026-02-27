using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Models.Cars.Europeans
{
    public class EuropeanEconomyCar : ICar
    {
        public void DisplaySpecifications()
        {
            Console.WriteLine("European Economy Car Specifications:");
            Console.WriteLine($"Model: {GetModel()}");
            Console.WriteLine($"Price: ${GetPrice()}");
            Console.WriteLine($"Acceleration (0-100 km/h): {GetAcceleration()} sec");
            Console.WriteLine($"Top Speed: {GetTopSpeed()} km/h");
        }

        public double GetAcceleration() => 9.2;


        public string GetChassisType() => "Monocoque";



        public double GetFuelConsumption() => 5.2;


        public string GetFuelType() => "Diesel";
        

        public string GetModel() => "European Compact Hatchback";


        public double GetPrice() => 22000;


        public double GetTopSpeed() => 180;
        
    }
}
