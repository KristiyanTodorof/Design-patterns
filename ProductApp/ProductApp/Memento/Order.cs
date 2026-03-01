using ProductApp.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Memento
{
    public class Order
    {
        private List<IProduct> _products = new List<IProduct>();
        private double _totalPrice = 0;

        public void AddProduct(IProduct product)
        {
            this._products.Add(product);
            this._totalPrice += product.GetPrice();
        }

        public OrderMemento Save()
        {
            return new OrderMemento(this._products, this._totalPrice);
        }

        public void Clear()
        {
            this._products.Clear();
            this._totalPrice = 0;
        }

        public List<IProduct> GetProducts()
        {
            return new List<IProduct>(this._products);
        }

        public double GetTotalPrice()
        {
            return this._totalPrice;
        }
    }
}
