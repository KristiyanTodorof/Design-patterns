using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Additives
{
    public class Milk : ICoffeeAdditive
    {
        public string Mix()
        {
            return "Milk";
        }
    }
}
