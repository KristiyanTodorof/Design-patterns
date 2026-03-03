using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Interfaces
{
    public interface ITicketStorageImplementation
    {
        public void AddTicket(MovieTicket ticket);
        public void RemoveTicket(string ticketId);
        MovieTicket GetTicket(string ticketId);
        ICollection<MovieTicket> GetAllTicket();
    }
}
