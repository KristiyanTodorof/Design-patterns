using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Services
{
    public class EcosystemSimulator
    {
        private readonly IEcosystemFactory _factory;
        private readonly IAnimal _predator;
        private readonly IAnimal _secondarySpecies;
        private readonly IHabitat _habitat;

        public EcosystemSimulator(IEcosystemFactory factory)
        {
            this._factory = factory;
            this._predator = _factory.CreatePredator();
            this._secondarySpecies = _factory.CreateSecondarySpecies();
            this._habitat = _factory.CreateHabitat();
        }

        public void Simulation()
        {
            Console.WriteLine("\nEcosystem Simulation:");
            _habitat.Describe();

            Console.WriteLine("\nPredator Behavior:");
            _predator.MakeSound();
            _predator.Move();

            Console.WriteLine("Secondary Species Behavior:");
            _secondarySpecies.MakeSound();
            _secondarySpecies.Move();
        }
    }
}
