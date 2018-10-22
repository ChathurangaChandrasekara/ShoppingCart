using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Home.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            this.ItemList = new List<ItemDTO>();
            this.Category = new List<int>();
            this.ListCategory = new List<ItemCategory>();
        }
        public List<SignUp> ShopList { get; set; }

        public List<ItemDTO> ItemList  { get; set; }

        public int Length { get; set; }

        public List<int> Category { get; set; }

        public List<ItemCategory> ListCategory { get; set; }
    }
}
