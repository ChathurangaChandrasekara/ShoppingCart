using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Shop.Models
{
    public class ItemCategoryDTO
    {
        [Key]
        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }

        public SignUp signUp;
        public int SignUpId { get; set; }
        public string Name { get; set; }
    }
}
