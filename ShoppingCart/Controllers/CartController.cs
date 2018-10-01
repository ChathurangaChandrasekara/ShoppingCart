using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Concrete;
using ShoppingCart.Models;
using ShoppingCart.ViewModels;

namespace ShoppingCart.Controllers
{
    public class CartController : Controller
    {
        private ShoppingCartDbContext _db;
        private readonly IItemData _itemData;
        private readonly CartData _cartData;

        public CartController(IItemData itemData, CartData cartData, ShoppingCartDbContext db)
        {
            _itemData = itemData;
            _cartData = cartData;
            _db = db;
        }

        public ViewResult Index()
        {
            var items = _cartData.GetShoppingCartItems();
            _cartData.shoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _cartData,
                ShoppingCartTotal = _cartData.GetShoppingCartTotal()
            };
            return View(sCVM);
        }

         public ActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _db.Items.FirstOrDefault(x => x.ItemId == itemId);
            if (selectedItem != null)
            {
                _cartData.AddToCart(selectedItem, 1); 
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = _db.Items.FirstOrDefault(x => x.ItemId == itemId);
            if (selectedItem != null)
            {
                _cartData.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }

        public ActionResult ClearCart()
        {
            _cartData.ClearCart();
            return RedirectToAction("Index");
        }


    }
}