using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int? PhoneNumber { get; set; }
        public string Name { get; set; }
    }
}
