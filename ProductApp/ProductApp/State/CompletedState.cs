using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.State
{
    public class CompletedState : IProductionState
    {
        public void ProcessStage(ProductionContext context)
        {
            Console.WriteLine("Продуктът е завършен!");
        }

        public string GetStateDescription()
        {
            return "Готов за доставка";
        }
    }
}
