using ShoppingCart.Abstract;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class OrderData : IOrderData
    {
        private readonly ShoppingCartDbContext _db;
        private readonly CartData _cartData;
        public OrderData(ShoppingCartDbContext db, CartData cartData)
        {
            _db = db;
            _cartData = cartData;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _db.Orders.Add(order);

            var shoppingCartItems = _cartData.shoppingCartItems;
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    ItemId = item.item.ItemId,
                    OrderId = order.OrderId,
                    Price = item.item.UnitPrice
                };
                _db.OrderDetails.Add(orderDetail);

            }
            _db.SaveChanges();
        }
    }
}
