using System;
using System.Collections.Generic;

namespace PizzaApp
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual CustomerAddress CustomerAddressId { get; set; }
    }
}
