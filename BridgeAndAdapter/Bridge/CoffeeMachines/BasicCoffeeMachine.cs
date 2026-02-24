using Bridge.Additives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeMachines
{
    public class BasicCoffeeMachine : CoffeeMachine

    {
        public BasicCoffeeMachine(ICoffeeAdditive additive) : base(additive)
        {
        }
    }
}
