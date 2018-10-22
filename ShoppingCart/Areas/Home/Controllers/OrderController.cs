using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Concrete;

namespace ShoppingCart.Areas.Home.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderData _orderData;
        private readonly CartData _cartData;

        public OrderController(IOrderData orderData, CartData cartData)
        {
            _cartData = cartData;
            _orderData = orderData;
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}