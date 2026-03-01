using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.State
{
    public class StageTwoState : IProductionState
    {
        public void ProcessStage(ProductionContext context)
        {
            Console.WriteLine("Етап 2: Обработка на продукт...");
            context.SetCurrentState(new StageThreeState());
        }

        public string GetStateDescription()
        {
            return "Етап 2: Асемблиране";
        }
    }
}
