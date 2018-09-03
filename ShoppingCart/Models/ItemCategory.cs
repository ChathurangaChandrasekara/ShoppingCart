using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class ItemCategory
    {
        
        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }

        public SignUp signUp;
        public int SignUpId { get; set; }

    }
}
