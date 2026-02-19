using AnimalsFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsFactoryMethod.Models
{
    public class Tiger : IAnimal
    {
     
        public void Buy()
        {
            Console.WriteLine("You just bought a tiger for 3000 dollars.");
        }

        public void Feed()
        {
            Console.WriteLine("Feeding a tiger with meat.");
        }

        public void Sell()
        {
            Console.WriteLine("You just sell the tiger for 1500 dollars.");
        }
    }
}
