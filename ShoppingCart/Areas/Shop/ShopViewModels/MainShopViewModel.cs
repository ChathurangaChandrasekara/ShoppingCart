using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Shop.ShopViewModels
{
    public class MainShopViewModel
    {
        public SignUp signUpDetails { get; set; }
        
        public MoreDetail moreDetail { get; set; }

        public List<ItemDTO> items { get; set; }

        public List<ItemCategory> CategoryList { get; set; }
    }
}
