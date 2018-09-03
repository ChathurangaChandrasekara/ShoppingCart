using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Areas.Shop.Models;

namespace ShoppingCart.Areas.Shop.Controllers
{
    public class ShopController : Controller
    {
        public IShopData _shopData;
        public ShopController(IShopData shopData)
        {
            _shopData = shopData;
        }


        // ******* View Shop Details ********
        [HttpGet]
        public ActionResult Index(int id)
        {
            TempData["id"] = id;
            return View(_shopData.ShopDetailId(id));
        }



        // GET: Shop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // *
        
        public ActionResult Create(int Id)
        {

            return View();
        }

        // POST: Shop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Shop/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MoreDetailDTO obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    
                    return RedirectToAction("Index", "Shop");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return View();
        }

        // GET: Shop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}