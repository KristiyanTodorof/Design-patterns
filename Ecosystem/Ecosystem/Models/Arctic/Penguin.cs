using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Models.Arctic
{
    public class Penguin : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Honk honk!");
        }

        public void Move()
        {
            Console.WriteLine("Penguin waddles on ice and swims gracefully");
        }
    }
}
