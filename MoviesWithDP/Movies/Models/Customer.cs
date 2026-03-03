using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Customer
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Customer(string id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }
    }
}
