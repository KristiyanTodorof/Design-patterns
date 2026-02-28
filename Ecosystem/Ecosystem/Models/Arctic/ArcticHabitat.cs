using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Models.Arctic
{
    public class ArcticHabitat : IHabitat
    {
        public void Describe()
        {
            Console.WriteLine("An Arctic habitat is a cold, icy environment characterized by freezing temperatures, snow, and ice.");
        }
    }
}
