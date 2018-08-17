using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string ImageUrl { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public ItemCategory itemCategory { get; set; }

        public SignUp signUp { get; set; }

    }
}
