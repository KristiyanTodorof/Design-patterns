using Movies.Interfaces;
using Movies.Models.MovieTickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Factories
{
    public class MovieTicketFactory
    {
        public static StandardMovieTicket CreateStandardTicket(string id,
        string movieTitle,
        DateTime showTime,
        ITicketStorageImplementation storage)
        {
            return new StandardMovieTicket(id, movieTitle, showTime, storage);
        }
        public static PremiumMovieTicket CreatePremiumTicket(string id,
        string movieTitle,
        DateTime showTime,
        string screenType,
        ITicketStorageImplementation storage)
        {
            return new PremiumMovieTicket(id, movieTitle, showTime, screenType, storage);
        }
    }
}
