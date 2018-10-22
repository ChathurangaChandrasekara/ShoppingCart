using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Abstract;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class CartData : ICartData
    {
        private readonly ShoppingCartDbContext _shoppingCartDbContext;
        public CartData(ShoppingCartDbContext shoppingCartDbContext)
        {
            _shoppingCartDbContext = shoppingCartDbContext;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        
        public void AddToCart(Item item, int Amount)
        {
            var shoppingCartItem = _shoppingCartDbContext.ShoppingCartItems.SingleOrDefault(x => x.item.ItemId == item.ItemId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    // ShoppingCartId = ShoppingCartId,
                    item = item,
                    Amount = 1
                    
                };
                item.Quantity = item.Quantity - 1;
                _shoppingCartDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _shoppingCartDbContext.SaveChanges();
        }

        public void ClearCart()
        {
            var cartItems = _shoppingCartDbContext.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId);
            _shoppingCartDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _shoppingCartDbContext.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return shoppingCartItems ?? (shoppingCartItems = _shoppingCartDbContext.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId).Include(s => s.item).ToList());
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _shoppingCartDbContext.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId).Select(s => s.item.UnitPrice * s.Amount).Sum();
            return total;
        }

        public int RemoveFromCart(Item item)
        {
            var shoppingCartItem = _shoppingCartDbContext.ShoppingCartItems.SingleOrDefault(x => x.item.ItemId == item.ItemId && x.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _shoppingCartDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _shoppingCartDbContext.SaveChanges();
            return localAmount;
        }

       
    }
}
