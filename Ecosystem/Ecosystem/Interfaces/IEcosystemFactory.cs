using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Interfaces
{
    public interface IEcosystemFactory
    {
        IAnimal CreatePredator();
        IAnimal CreateSecondarySpecies();
        IHabitat CreateHabitat();

    }
}
