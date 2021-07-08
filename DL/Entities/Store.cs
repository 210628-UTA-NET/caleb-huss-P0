using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Store
    {
        public int StoreNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
