using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Shop.Models;

namespace ShoppingCart.Areas.Shop.Controllers
{
    public class ItemCategoryController : Controller
    {
        public IItemCategoryData _itemCategoryData;
        public ItemCategoryController(IItemCategoryData itemCategoryData)
        {
            _itemCategoryData = itemCategoryData;
        }
        // GET: ItemCategory
        public ActionResult Index(int id)
        {
            TempData["id"] = id;
            return View(_itemCategoryData.ShowList(id));
        }

        // GET: ItemCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemCategory/Create
        public ActionResult Create(int id)
        {
            TempData["id"] = id;
            return View();
        }

        // POST: ItemCategory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemCategoryDTO obj, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    _itemCategoryData.Created(obj);
                    return RedirectToAction("Index", "ItemCategory", new { id = id});
                }
                catch
                {
                    throw;
                }
            }
           return View();
        }

        // GET: ItemCategory/Edit/5
        [HttpGet]
        public ActionResult Edit(int edit, int id)
        {
            TempData["id"] = id;
            return View(_itemCategoryData.EditById(edit));
        }

        // POST: ItemCategory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemCategoryDTO obj,int id)
        {
            if (ModelState.IsValid)
            {


                try
                {

                    _itemCategoryData.Edited(obj);
                    return RedirectToAction("Index", "ItemCategory", new { id = id });
                }
                catch
                {
                    throw;
                }
            }
            return View();
        }

        // GET: ItemCategory/Delete/5
        [HttpGet]
        public ActionResult Delete(int delete, int id)
        {
            TempData["delete"] = delete;
            TempData["id"] = id;
            return View(_itemCategoryData.DeleteById(delete,id));
        }

        // POST: ItemCategory/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteData(int ItemCategoryId, int SignUpId)
        {
            
            try
                {

                    _itemCategoryData.Deleted(ItemCategoryId, SignUpId);
                    return RedirectToAction("Index", "ItemCategory", new { id = SignUpId});
                }
                catch(Exception ex)
                {
                    throw;
                }
           
            return View();
        }
    }
}