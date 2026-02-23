using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRegistrySingleton
{
    public class AnimalRegistry
    {
        private static AnimalRegistry _instane;
        private static Dictionary<string, string> _registeredAnimal;
        private AnimalRegistry()
        {
            Console.WriteLine("Animal Registry created - there can be only one!");
            _registeredAnimal = new Dictionary<string, string>();
        }
        public static AnimalRegistry GetInstance()
        {
            if (_instane == null) 
            {
                _instane = new AnimalRegistry();
            }
            return _instane;
        }

        public void RegisterAnimal(string name, string species) 
        {
            if (!_registeredAnimal.ContainsKey(name))
            {
                _registeredAnimal.Add(name, species);
                Console.WriteLine($"Registered {species} with name {name}");
            }
            else
            {
                Console.WriteLine($"An animal with name {name} is already registered");
            }
        }
        public string GetAnimalSpecies(string name)
        {
            if (_registeredAnimal.ContainsKey(name))
            {
                return _registeredAnimal[name];
            }

            return "Animal not found";
        }
        public void ListAllAnimals()
        {
            if (_registeredAnimal.Count == 0)
            {
                Console.WriteLine("No animals registered yet");
                return;
            }

            Console.WriteLine("Registered Animals:");
            foreach (var animal in _registeredAnimal)
            {
                Console.WriteLine($"- {animal.Key} ({animal.Value})");
            }
        }
    }
}
