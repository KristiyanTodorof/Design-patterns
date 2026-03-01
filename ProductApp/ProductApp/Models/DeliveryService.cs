using ProductApp.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class DeliveryService
    {
        public void PrepareDelivery(IProduct product, double deliveryPrice)
        {
            Console.WriteLine($"[Доставка]: Подготвя се доставка на продукт {product.GetType()} " +
                             $"с цвят {product.GetColor()}. Цена за доставка: {deliveryPrice:F2} лв.");
        }
    }
}
