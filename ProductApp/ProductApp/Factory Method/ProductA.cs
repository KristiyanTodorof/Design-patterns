using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Factory_Method
{
    public class ProductA : IProduct
    {
        private string _color;
        private readonly double _price = 100.0;

        public void SetColor(string color)
        {
            this._color = color;
        }
        public string GetColor()
        {
            return this._color;
        }

        public double GetPrice()
        {
            return this._price;
        }

        string IProduct.GetType()
        {
            return "ProductA";
        }
    }
}
