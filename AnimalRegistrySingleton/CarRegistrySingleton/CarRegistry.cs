using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRegistrySingleton
{
    public class CarRegistry
    {
        private static CarRegistry _instance;
        private static Dictionary<string, string> _registeredCars;

        private CarRegistry()
        {
            Console.WriteLine("Car Registry created - there can be only one!");
            _registeredCars = new Dictionary<string, string>();
        }
        public static CarRegistry GetInstance()
        {
            if (_instance == null) 
            {
                _instance = new CarRegistry();
            }
            return _instance;
        }
        public void RegisterCar(string model, string owner)
        {
            if (!_registeredCars.ContainsKey(model))
            {
                _registeredCars.Add(model, owner);
                Console.WriteLine($"Registered {owner} with {model}");
            }
            else
            {
                Console.WriteLine($"A model {model} is already registered");
            }
        }
        public string GetCarModels(string model)
        {
            if (_registeredCars.ContainsKey(model))
            {
                return _registeredCars[model];
            }

            return "Animal not found";
        }
        public void ListAllCars()
        {
            if (_registeredCars.Count == 0)
            {
                Console.WriteLine("No cars registered yet");
                return;
            }

            Console.WriteLine("Registered Cars:");
            foreach (var car in _registeredCars)
            {
                Console.WriteLine($"- {car.Key} ({car.Value})");
            }
        }
    }
}
