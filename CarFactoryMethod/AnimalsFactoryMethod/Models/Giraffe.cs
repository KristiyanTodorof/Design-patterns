using AnimalsFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFactoryMethod.Models
{
    public class Giraffe : IAnimal
    {

        public void Buy()
        {
            Console.WriteLine("You just bought a giraffe for 4000 dollars.");
        }

        public void Feed()
        {
            Console.WriteLine("Feeding a panda with bamboo.");
        }

        public void Sell()
        {
            Console.WriteLine("You just sell the panda for 2000 dollars");
        }
    }
}
