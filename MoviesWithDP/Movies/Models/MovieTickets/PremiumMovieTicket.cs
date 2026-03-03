using Movies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models.MovieTickets
{
    public class PremiumMovieTicket : MovieTicket
    {
        public string ScreenType { get; private set; }
        public PremiumMovieTicket(string id, string movieTitle, DateTime showTime,string screenType, ITicketStorageImplementation storageImplementation) 
            : base(id, movieTitle, showTime, storageImplementation)
        {
            this.ScreenType = screenType;
        }

        public override decimal CalculatePrice()
        {
            return 22.00m;
        }

        public override string ToString()
        {
            return $"Premium {this.ScreenType} Ticket {this.Id}: {this.MovieTitle} at {this.ShowTime:g}";
        }
    }
}
