using Bridge.Additives;
using Bridge.CoffeeMachines;
using Bridge.Commands;
using Bridge.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class CoffeeSystem
    {
        public static void Main()
        {
            ICoffeeAdditive milk = new Milk();
            ICoffeeAdditive cream = new Cream();

            CoffeeMachine coffeeMachine = new BasicCoffeeMachine(milk);

            ICoffeeCommand longCoffeeCommand = new MakeLongCoffeeCommand(coffeeMachine);
            ICoffeeCommand shortCoffeeCommand = new MakeShortCoffeeCommand(coffeeMachine);

            Remote remote = new Remote();
            Phone phone = new Phone();

            remote.SetCommand(longCoffeeCommand);
            Console.WriteLine(remote.PressButton());

            phone.SetCommand(shortCoffeeCommand);
            Console.WriteLine(phone.TapButton());

            coffeeMachine.ChangeAdditive(cream);

            remote.SetCommand(shortCoffeeCommand);
            Console.WriteLine(remote.PressButton());
        }
    }
}