using Bridge.Additives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CoffeeMachines
{
    public abstract class CoffeeMachine
    {
        protected ICoffeeAdditive _additive;
        protected CoffeeMachine(ICoffeeAdditive additive)
        {
            this._additive = additive;
        }
        public void ChangeAdditive(ICoffeeAdditive additive)
        {
            this._additive = additive;
        }
        public string MakeLongCoffee()
        {
            return $"Making long coffee with {this._additive.Mix()}";
        }
        public string MakeShortCoffee() 
        {
            return $"Making short coffee with {this._additive.Mix()}";
        }
    }
}
