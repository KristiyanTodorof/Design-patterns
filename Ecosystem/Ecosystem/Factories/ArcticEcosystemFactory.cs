using Ecosystem.Interfaces;
using Ecosystem.Models.Arctic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Factories
{
    public class ArcticEcosystemFactory : IEcosystemFactory
    {
        public IHabitat CreateHabitat()
        {
            return new ArcticHabitat();
        }

        public IAnimal CreatePredator()
        {
            return new PolarBear();
        }

        public IAnimal CreateSecondarySpecies()
        {
            return new Penguin();
        }
    }
}
