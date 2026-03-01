using ProductApp.Factory_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Memento
{
    public class OrderMemento
    {
        private readonly List<IProduct> _products;
        private readonly double _totalPrice;
        private readonly DateTime _orderDate;

        public OrderMemento(List<IProduct> products, double totalPrice)
        {
            this._products = new List<IProduct>(products);
            this._totalPrice = totalPrice;
            this._orderDate = DateTime.Now;
        }

        public List<IProduct> GetProducts()
        {
            return new List<IProduct>(_products);
        }

        public double GetTotalPrice()
        {
            return this._totalPrice;
        }

        public DateTime GetOrderDate()
        {
            return this._orderDate;
        }
    }
}
