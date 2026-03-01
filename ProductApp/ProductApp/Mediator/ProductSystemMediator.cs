using ProductApp.Factory_Method;
using ProductApp.Memento;
using ProductApp.Models;
using ProductApp.Production;
using ProductApp.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Mediator
{
    public class ProductSystemMediator : IProductMediator
    {
        private readonly ProductFactory _productFactory;
        private readonly DeliveryService _deliveryService;
        private readonly Cart _cart;
        private readonly Dictionary<IProduct, Client> _productClientMap = new Dictionary<IProduct, Client>();

        public ProductSystemMediator(ProductFactory productFactory, DeliveryService deliveryService, Cart cart)
        {
            this._productFactory = productFactory;
            this._deliveryService = deliveryService;
            this._cart = cart;
        }

        public void NotifyDeliveryReady(IProduct product, double deliveryPrice)
        {
            this._deliveryService.PrepareDelivery(product, deliveryPrice);
        }

        public void NotifyProductionProgress(IProduct product, int stage)
        {
            Client client = GetClientForProduct(product);
            if (client != null)
            {
                client.ReceiveNotification($"Продуктът {product.GetType()} е в етап {stage} от производството.");

                if (stage == 3)
                {
                    client.ReceiveNotification($"Продуктът {product.GetType()} е завършен и готов за доставка.");

                    double deliveryPrice = CalculateDeliveryPrice(product);
                    NotifyDeliveryReady(product, deliveryPrice);
                }
            }
        }

        public void RegisterOrder(List<IProduct> products, Client client)
        {
            Order order = new Order();
            foreach (var product in products)
            {
                order.AddProduct(product);
            }

            // Запазване на поръчката в историята
            this._cart.AddOrder(order.Save(), client);
        }

        public void RequestProductCreation(string productType, string color, Client client)
        {
            IProduct product = this._productFactory.CreateProduct(productType);
            product.SetColor(color);

            AssociateProductWithClient(product, client);

            ProductionProcess process = new ProductionProcess(product, this);
            ProductionContext context = new ProductionContext(product, process);

            for (int i = 0; i < 3; i++)
            {
                context.NextStage();
            }

        }
        private Client GetClientForProduct(IProduct product)
        {
            if (this._productClientMap.ContainsKey(product))
            {
                return this._productClientMap[product];
            }
            return null;
        }
        private double CalculateDeliveryPrice(IProduct product)
        {
            return product.GetPrice() * 0.1 + 10;
        }
        private void AssociateProductWithClient(IProduct product, Client client)
        {
            this._productClientMap[product] = client;
        }
    }
}
