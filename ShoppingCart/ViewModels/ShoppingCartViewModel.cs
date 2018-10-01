using ShoppingCart.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModels
{
    public class ShoppingCartViewModel
    {
        public CartData ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }

    }
}
