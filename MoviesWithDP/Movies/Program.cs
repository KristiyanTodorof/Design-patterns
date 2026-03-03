using Movies.Factories;
using Movies.Interfaces;
using Movies.Models.MovieTickets;
using Movies.Models;
using Movies.Services;
using Movies.Storage;

ITicketStorageImplementation databaseStorage = new DatabaseTicketStorage();

MovieTicketingSystem ticketSystem = new MovieTicketingSystem(databaseStorage);

Customer customer = new Customer("CINEMACITY001", "Kistiyan Todorov", "todorovk585@gmail.com");

StandardMovieTicket standardTicket = MovieTicketFactory.CreateStandardTicket(
    "CINEMACITY001",
    "Inception",
    DateTime.Now.AddDays(1).AddHours(2),
    databaseStorage
);

PremiumMovieTicket premiumTicket = MovieTicketFactory.CreatePremiumTicket(
    "IMAX001",
    "Interstellar",
    DateTime.Now.AddDays(2).AddHours(4),
    "IMAX",
    databaseStorage
);

ticketSystem.AssignCustomerToTicket(standardTicket, customer);
ticketSystem.AssignCustomerToTicket(premiumTicket, customer);

ticketSystem.CreateTicket(standardTicket);
ticketSystem.CreateTicket(premiumTicket);

Console.WriteLine("Tickets:");
foreach (var ticket in ticketSystem.GetAllTickets())
{
    Console.WriteLine(ticket);
}