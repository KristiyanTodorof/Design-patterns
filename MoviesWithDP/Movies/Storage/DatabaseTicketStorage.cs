using Movies.Interfaces;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Storage
{
    public class DatabaseTicketStorage : ITicketStorageImplementation
    {
        private Dictionary<string, MovieTicket> _tickets = new Dictionary<string, MovieTicket>();
        public void AddTicket(MovieTicket ticket)
        {
            _tickets[ticket.Id] = ticket;
            Console.WriteLine($"Ticket {ticket.Id} added to Database storage");
        }

        public ICollection<MovieTicket> GetAllTicket()
        {
            return new List<MovieTicket>(_tickets.Values);
        }

        public MovieTicket GetTicket(string ticketId)
        {
            return _tickets.TryGetValue(ticketId, out var ticket) ? ticket : null;
        }

        public void RemoveTicket(string ticketId)
        {
            if (_tickets.ContainsKey(ticketId)) 
            {
                _tickets.Remove(ticketId);
                Console.WriteLine($"Ticket {ticketId} removed from Database Storage");
            }
        }
    }
}
