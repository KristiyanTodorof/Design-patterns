using Movies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models.MovieTickets
{
    public class StandardMovieTicket : MovieTicket
    {
        public StandardMovieTicket(string id, string movieTitle, DateTime showTime, ITicketStorageImplementation storageImplementation) 
            : base(id, movieTitle, showTime, storageImplementation)
        {
        }

        public override decimal CalculatePrice()
        {
            return 12.50m;
        }

        public override string ToString()
        {
            return $"Standard Ticket {this.Id}: {this.MovieTitle} at {this.ShowTime:g}";
        }
    }
}
