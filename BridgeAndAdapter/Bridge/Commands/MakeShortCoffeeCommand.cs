using Bridge.CoffeeMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Commands
{
    public class MakeShortCoffeeCommand : ICoffeeCommand
    {
        private readonly CoffeeMachine _coffeeMachine;
        public MakeShortCoffeeCommand(CoffeeMachine coffeeMachine)
        {
            this._coffeeMachine = coffeeMachine;
        }
        public string Execute()
        {
            return this._coffeeMachine.MakeShortCoffee();
        }
    }
}
