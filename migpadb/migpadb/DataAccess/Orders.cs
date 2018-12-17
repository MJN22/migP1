using System;
using System.Collections.Generic;

namespace PizzaApp
{
    public partial class Orders
    {
        public int CustomerAddressId { get; set; }
        public int StoreAddressId { get; set; }
        public int Id { get; set; }
        public int OrderId { get; set; }

        public virtual OrderDetails IdNavigation { get; set; }
        public virtual Store StoreAddress { get; set; }
        public virtual CustomerAddress CustomerOrderAddress { get; set; }
    }
}
