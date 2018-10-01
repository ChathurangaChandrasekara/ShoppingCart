using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModels
{
    public class HomeViewModel 
    {
        public List<SignUp> ShopList { get; set; }
        public string FullName { get; set; }

        public List<Item> ItemList1 { get; set; }
        public List<Item> ItemList2 { get; set; }
        public List<Item> ItemList3 { get; set; }
        public List<Item> ItemList4 { get; set; }
        public List<Item> ItemList5 { get; set; }
    }
}
