using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.State
{
    public interface IProductionState
    {
        void ProcessStage(ProductionContext context);
        string GetStateDescription();

    }
}
