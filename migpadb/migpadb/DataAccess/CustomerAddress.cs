using System;
using System.Collections.Generic;

namespace PizzaApp
{
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ProvidenceState { get; set; }
        public string PostalCode { get; set; }
        public string CountryAbrev { get; set; }

        public virtual Customer UserAddressNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
