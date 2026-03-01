using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.State
{
    public class StageOneState : IProductionState
    {
        public void ProcessStage(ProductionContext context)
        {
            Console.WriteLine("Етап 1: Начало на производство...");
            context.SetCurrentState(new StageTwoState());
        }

        public string GetStateDescription()
        {
            return "Етап 1: Подготовка на материали";
        }
    }
}
