using ProductApp.Factory_Method;
using ProductApp.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.State
{
    public class ProductionContext
    {
        private IProductionState _currentState;
        private readonly IProduct _product;
        private readonly ProductionProcess _productionProcess;

        public ProductionContext(IProduct product, ProductionProcess productionProcess)
        {
            this._product = product;
            this._productionProcess = productionProcess;
            this._currentState = new StageOneState();
        }

        public void SetCurrentState(IProductionState state)
        {
            this._currentState = state;

            if (state is StageOneState)
            {
                this._productionProcess.NextStage();
            }
            else if (state is StageTwoState)
            {
                this._productionProcess.NextStage();
            }
            else if (state is StageThreeState)
            {
                this._productionProcess.NextStage();
            }
            else if (state is CompletedState)
            {
                this._productionProcess.NextStage();
            }
        }

        public void NextStage()
        {
            this._currentState.ProcessStage(this);
        }

        public string GetCurrentStateDescription()
        {
            return this._currentState.GetStateDescription();
        }

        public IProduct GetProduct()
        {
            return this._product;
        }
    }
}
