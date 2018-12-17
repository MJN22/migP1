using System;
using System.Collections.Generic;

namespace PizzaApp
{
    public partial class Pizza
    {
        public Pizza()
        {
            OrderDetails = new HashSet<OrderDetails>();
            PizzaIngredients = new HashSet<PizzaIngredients>();
        }

        public int Id { get; set; }
        public string PizzaName { get; set; }
        public decimal Costs { get; set; }
       

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<PizzaIngredients> PizzaIngredients { get; set; }
    }
}
