using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface ICartData
    {
        string ShoppingCartId { get; set; }
        List<ShoppingCartItem> shoppingCartItems { get; set; }

        void AddToCart(Item item, int Amount);

        int RemoveFromCart(Item item);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
    }
}
