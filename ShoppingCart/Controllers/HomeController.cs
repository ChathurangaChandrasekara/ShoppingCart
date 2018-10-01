using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCart.ViewModels;

namespace ShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        ShoppingCartDbContext _db;
        public HomeController(ShoppingCartDbContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.ShopList = _db.SignUps.Where(x => x.LoginType == "Shop" & x.Active == true).ToList();

            //homeViewModel.ItemList1 = _db.Items

            return View(homeViewModel);
        }

       
    }
}
