using CarManufacturing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturing.Services
{
    public class CarManufacturingSimulator
    {
        public static void DisplayEngineDetails(IEngine engine)
        {
            Console.WriteLine("Engine Specifications:");
            Console.WriteLine($"Type: {engine.GetEngineType()}");
            Console.WriteLine($"Manufacturer: {engine.GetManufacturer()}");
            Console.WriteLine($"Horsepower: {engine.GetHorsepower()} HP");
            Console.WriteLine($"Torque: {engine.GetTorque()} Nm");
            Console.WriteLine($"Emission Level: {engine.GetEmissionLevel()} g/km");
            Console.WriteLine($"Performance Index: {engine.CalculatePerformance():F2}\n");
        }

        public static void SimulateProduction(ICarFactory factory)
        {
            Console.WriteLine($"--- {factory.GetRegionOfOrigin()} Car Manufacturing Simulation ---");

            ICar luxuryCar = factory.CreateLuxuryCar();
            ICar economyCar = factory.CreateEconomyCar();
            ICar sportsCar = factory.CreateSportsCar();

            IEngine luxuryEngine = factory.CreateLuxuryEngine();
            IEngine economyEngine = factory.CreateEconomyEngine();
            IEngine sportsEngine = factory.CreateSportsEngine();

            Console.WriteLine("Luxury Car:");
            luxuryCar.DisplaySpecifications();
            DisplayEngineDetails(luxuryEngine);
            Console.WriteLine($"Production Cost: {factory.CalculateProductionCost(luxuryCar):C2}\n");

            Console.WriteLine("Economy Car:");
            economyCar.DisplaySpecifications();
            DisplayEngineDetails(economyEngine);
            Console.WriteLine($"Production Cost: {factory.CalculateProductionCost(economyCar):C2}\n");

            Console.WriteLine("Sports Car:");
            sportsCar.DisplaySpecifications();
            DisplayEngineDetails(sportsEngine);
            Console.WriteLine($"Production Cost: {factory.CalculateProductionCost(sportsCar):C2}\n");
        }
    }
}
