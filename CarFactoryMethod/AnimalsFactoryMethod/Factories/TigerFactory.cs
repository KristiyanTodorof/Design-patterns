using AnimalsFactoryMethod.Interfaces;
using AnimalsFactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFactoryMethod.Factories
{
    public class TigerFactory : AnimalFactory
    {
        protected override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
