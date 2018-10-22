using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cart
    {
        private readonly ShoppingCartDbContext _db;
        private Cart(ShoppingCartDbContext db)
        {
            _db = db;
        }

        public string ShoppingCartId { get; set; }
        public int pssingId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }


        public static Cart GetCart(IServiceProvider services)
        {

            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ShoppingCartDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new Cart(context) { ShoppingCartId = cartId};
        }

        public void AddToCart(Item item, int Amount)
        {
            var shoppingCartItem = _db.ShoppingCartItems.SingleOrDefault(x => x.item.ItemId == item.ItemId && x.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    item = item,
                    Amount = 1
                };
                _db.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _db.SaveChanges();
        }

        public int RemoveFromCart(Item item)
        {
            var shoppingCartItem = _db.ShoppingCartItems.SingleOrDefault(x => x.item.ItemId == item.ItemId && x.ShoppingCartId == ShoppingCartId);

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
                    _db.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _db.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _db.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId).Include(s => s.item).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _db.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId);
            _db.ShoppingCartItems.RemoveRange(cartItems);
            _db.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _db.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId).Select(s => s.item.UnitPrice * s.Amount).Sum();
            return total;
        }
    }
}
 