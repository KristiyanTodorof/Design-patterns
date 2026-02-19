using AnimalsFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFactoryMethod.Factories
{
    public abstract class AnimalFactory
    {
        protected abstract IAnimal CreateAnimal();
        
        public void SeeAnimal()
        {
            IAnimal animal = CreateAnimal();
            Console.WriteLine("Preparing animal for visitation...");
            animal.Buy();
            animal.Feed();
            animal.Sell();
            Console.WriteLine("Animal visited!\n");
        }
    }
}
