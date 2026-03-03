using Movies.Interfaces;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Services
{
    public class MovieTicketingSystem
    {
        private ITicketStorageImplementation _storage;

        public MovieTicketingSystem(ITicketStorageImplementation storage)
        {
            this._storage = storage;
        }
        public MovieTicket CreateTicket(MovieTicket ticket)
        {
            ticket.Save();
            return ticket;
        }
        public void AssignCustomerToTicket(MovieTicket ticket, Customer customer)
        {
            ticket.AssignCustomer(customer);
        }
        public List<MovieTicket> GetAllTickets()
        {
            return (List<MovieTicket>)_storage.GetAllTicket();
        }
    }
}
