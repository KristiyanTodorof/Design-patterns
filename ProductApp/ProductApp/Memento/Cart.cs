using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Memento
{
    public class Cart
    {
        private readonly Dictionary<Client, List<OrderMemento>> _clientOrderHistory = new Dictionary<Client, List<OrderMemento>>();

        public void AddOrder(OrderMemento memento, Client client)
        {
            if (!this._clientOrderHistory.ContainsKey(client))
            {
                this._clientOrderHistory[client] = new List<OrderMemento>();
            }
            this._clientOrderHistory[client].Add(memento);
        }

        public List<OrderMemento> GetOrderHistory(Client client)
        {
            if (this._clientOrderHistory.ContainsKey(client))
            {
                return new List<OrderMemento>(this._clientOrderHistory[client]);
            }
            return new List<OrderMemento>();
        }

        public Dictionary<Client, List<OrderMemento>> GetAllOrderHistory()
        {
            return new Dictionary<Client, List<OrderMemento>>(this._clientOrderHistory);
        }
    }
}
