using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    interface ICartData
    {
        
        void AddToCart(Item item, int Amount);
        int RemoveFromCart(Item item);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
    }
}
