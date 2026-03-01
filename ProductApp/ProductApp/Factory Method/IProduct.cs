using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Factory_Method
{
    public interface IProduct
    {
        void SetColor(string color);
        double GetPrice();
        string GetType();
        string GetColor();
    }
}
