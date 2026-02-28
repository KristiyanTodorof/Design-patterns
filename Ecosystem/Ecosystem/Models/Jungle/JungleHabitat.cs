using Ecosystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Models.Jungle
{
    public class JungleHabitat : IHabitat
    {
        public void Describe()
        {
            Console.WriteLine("A jungle habitat is a dense, " +
                "tropical forest with lush vegetation, abundant" +
                " rainfall, and a warm climate. It is home to diverse wildlife," +
                " including insects, birds, mammals, and reptiles, thriving in its rich ecosystem.");
        }
    }
}
