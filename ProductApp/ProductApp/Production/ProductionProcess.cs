using ProductApp.Factory_Method;
using ProductApp.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Production
{
    public class ProductionProcess
    {
        private readonly IProduct _product;
        private readonly IProductMediator _mediator;
        private int _currentStage = 0;

        public ProductionProcess(IProduct product, IProductMediator mediator)
        {
            this._product = product;
            this._mediator = mediator;
        }

        public void NextStage()
        {
            if (_currentStage < 3)
            {
                this._currentStage++;
                this._mediator.NotifyProductionProgress(this._product, this._currentStage);
            }
        }

        public int GetCurrentStage()
        {
            return this._currentStage;
        }

        public IProduct GetProduct()
        {
            return this._product;
        }
    }
}
