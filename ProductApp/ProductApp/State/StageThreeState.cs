using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.State
{
    public class StageThreeState : IProductionState
    {
        public void ProcessStage(ProductionContext context)
        {
            Console.WriteLine("Етап 3: Финализиране на продукт...");
            context.SetCurrentState(new CompletedState());
        }

        public string GetStateDescription()
        {
            return "Етап 3: Тестване и опаковане";
        }
    }
}
