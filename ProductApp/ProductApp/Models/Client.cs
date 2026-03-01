using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class Client
    {
        private readonly string _name;

        public Client(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public void ReceiveNotification(string message)
        {
            Console.WriteLine($"[Клиент {this._name} получи съобщение]: {message}");
        }
    }
}
