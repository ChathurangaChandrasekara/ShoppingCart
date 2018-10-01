using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string ImageUrl4 { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public ItemCategory itemCategory;
        public int ItemCategoryId { get; set; }


        public SignUp signUp;
        public int SignUpId { get; set; }

    }
}
