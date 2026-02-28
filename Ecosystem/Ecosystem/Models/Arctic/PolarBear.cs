using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Models.Arctic
{
    public class PolarBear : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Low growl!");
        }

        public void Move()
        {
            Console.WriteLine("Ploar bear walks across icy terrain");
        }
    }
}
