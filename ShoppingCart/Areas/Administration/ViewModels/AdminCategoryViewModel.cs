using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Administration.ViewModels
{
    public class AdminCategoryViewModel
    {
        ShoppingCartDbContext _db;
        List<ItemCategory> CategoryList { get; set; }
        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }

        List<SignUp> SignUpDetails { get; set; }
        public int SignUpId { get; set; }
        public string FullName { get; set; }

    }
}
