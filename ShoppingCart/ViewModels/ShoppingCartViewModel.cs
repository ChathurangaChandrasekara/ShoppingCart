using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModels
{
    public class ShoppingCartViewModel
    {
        public Cart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }
    }
}
