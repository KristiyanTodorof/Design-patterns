using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Models.Jungle
{
    public class Tiger : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Roar!");
        }

        public void Move()
        {
            Console.WriteLine("Tiger prowls silently through the undergrowth");
        }
    }
}
