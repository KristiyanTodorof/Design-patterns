using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Factory_Method
{
    public class ProductC : IProduct
    {
        private string _color;
        private readonly double _price = 200.0;
        public string GetColor()
        {
            return this._color;
        }

        public double GetPrice()
        {
            return this._price;
        }

        public void SetColor(string color)
        {
            this._color = color;
        }

        string IProduct.GetType()
        {
            return "ProductC";
        }
    }
}
