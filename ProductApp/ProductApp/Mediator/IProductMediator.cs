using ProductApp.Factory_Method;
using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Mediator
{
    public interface IProductMediator
    {
        void NotifyProductionProgress(IProduct product, int stage);
        void RequestProductCreation(string productType, string color, Client client);
        void RegisterOrder(List<IProduct> products, Client client);
        void NotifyDeliveryReady(IProduct product, double deliveryPrice);
    }
}
