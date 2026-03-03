using Movies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public abstract class MovieTicket
    {
        public string Id { get; protected set; }
        public string MovieTitle { get; protected set; }
        public DateTime ShowTime { get; protected set; }
        public Customer AssignedCustomer { get; protected set; }

        protected ITicketStorageImplementation _storageImplementation;

        protected MovieTicket(string id, string movieTitle, DateTime showTime, ITicketStorageImplementation storageImplementation)
        {
            this.Id = id;
            this.MovieTitle = movieTitle;
            this.ShowTime = showTime;
            this._storageImplementation = storageImplementation;
        }

        public abstract decimal CalculatePrice();

        public void AssignCustomer(Customer customer)
        {
            AssignedCustomer = customer;
        }

        public void Save()
        {
            _storageImplementation.AddTicket(this);
        }

        public void Remove()
        {
            _storageImplementation.RemoveTicket(Id);
        }
    }
}
