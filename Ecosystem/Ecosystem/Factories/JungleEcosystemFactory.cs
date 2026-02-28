using Ecosystem.Interfaces;
using Ecosystem.Models.Jungle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Factories
{
    public class JungleEcosystemFactory : IEcosystemFactory
    {
        public IHabitat CreateHabitat()
        {

            return new JungleHabitat();
        }

        public IAnimal CreatePredator()
        {
            return new Tiger();
        }

        public IAnimal CreateSecondarySpecies()
        {
            return new Monkey();
        }
    }
}
