using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Models.Jungle
{
    public class Monkey : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Oh oh ah ah!");
        }

        public void Move()
        {
            Console.WriteLine("Monkey swings between tree branches");
        }
    }
}
