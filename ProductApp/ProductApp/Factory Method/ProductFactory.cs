using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Factory_Method
{
    public class ProductFactory
    {
        public IProduct CreateProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                case "C":
                    return new ProductC();
                default:
                    throw new ArgumentException($"Неизвестен тип продукт: {type}");
            }
        }
    }
}
