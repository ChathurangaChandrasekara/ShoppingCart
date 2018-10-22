using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Concrete;
using ShoppingCart.Models;
using ShoppingCart.ViewModels;

namespace ShoppingCart.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ShoppingCartDbContext _db;
        private readonly IItemData _itemData;
        public ICartData _cartData;
       // private readonly Cart _cart;
       
        public CartController(IItemData itemData, ShoppingCartDbContext db, ICartData cartData) // Cart cart, meka contructor eka ethulata danna
        {
            _itemData = itemData;
            //_cart = cart;
            _db = db;
            _cartData = cartData;
        }

        //public ViewResult Index()
        //{
        //    var items = _cart.GetShoppingCartItems();
        //    _cart.ShoppingCartItems = items;

        //    var shoppingCartViewModel = new ShoppingCartViewModel
        //    {
        //        ShoppingCart = _cart,
        //        ShoppingCartTotal = _cart.GetShoppingCartTotal()
        //    };
        //    return View(shoppingCartViewModel);
        //}

        // public RedirectToActionResult AddToShoppingCart(int itemId)
        //{
        //      var selectedItem = _db.Items.FirstOrDefault(x => x.ItemId == itemId);
        //        if (selectedItem != null)
        //        {
        //            _cart.AddToCart(selectedItem, 1); 
        //        }
        //        return RedirectToAction("Index");
            
        //    //return RedirectToAction("Home", "Home", new { Areas = "Home" });
        //}

        //public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        //{
        //    var selectedItem = _db.Items.FirstOrDefault(x => x.ItemId == itemId);
        //    if (selectedItem != null)
        //    {
        //        _cart.RemoveFromCart(selectedItem);
        //    }
        //    return RedirectToAction("Index");
        //}

        //public ActionResult ClearCart()
        //{
        //    _cart.ClearCart();
        //    return RedirectToAction("Index");
        //}

        public ActionResult AddToShoppingCart(int id)
        {
            var selectedItem = _db.Items.FirstOrDefault(x => x.ItemId == id);
            if (selectedItem != null)
            {
                _cartData.AddToCart(selectedItem, 1);
            }
            return RedirectToAction("Index");
            
        }

    }
}