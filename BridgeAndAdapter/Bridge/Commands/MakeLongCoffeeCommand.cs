using Bridge.CoffeeMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Commands
{
    public class MakeLongCoffeeCommand : ICoffeeCommand
    {
        private readonly CoffeeMachine _coffeMachine;
        public MakeLongCoffeeCommand(CoffeeMachine coffeeMachine)
        {
            this._coffeMachine = coffeeMachine;
        }
        public string Execute()
        {
            return _coffeMachine.MakeLongCoffee();
        }
    }
}
