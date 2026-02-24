using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Additives
{
    public class Cream : ICoffeeAdditive
    {
        public string Mix()
        {
            return "Cream";
        }
    }
}
