using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;


namespace ShoppingCart.Areas.Shop.Controllers
{
    public class ItemController : Controller
    {
        ShoppingCartDbContext _db;
        
        
        public IItemData _itemData;
        public ItemController(IItemData itemData, ShoppingCartDbContext db)
        {
            _itemData = itemData;
            _db = db;


        }
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }

        // GET: Item/Details/5
        [HttpGet]
        public ActionResult ItemList(int id)
        {
            TempData["id"] = id;
            return View(_itemData.ItemList(id));
        }

        //******** item create  ********
        [HttpGet]
        public ActionResult Create(int id)
        {
            TempData["id"] = id;
            List<ItemCategory> itemCategorieslist = new List<ItemCategory>();
            itemCategorieslist = (from itemcategory in _db.ItemCategories.Where(x=> x.SignUpId == id) select itemcategory).ToList();
            itemCategorieslist.Insert(0, new ItemCategory { ItemCategoryId = 0, ItemCategoryName = "Select" });
            ViewBag.ListItemCategory = itemCategorieslist;
            

            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemDTO obj, List<IFormFile> ImageFile, int id)
        {
            string fileName = Path.GetFileNameWithoutExtension(obj.ImageFile.ToString());
            string extension = Path.GetExtension(obj.ImageFile.ToString());
            fileName = fileName + extension;
            var url = "/ItemImage" + fileName;
            fileName = Path.Combine((url), fileName);
            obj.ImageFile.Equals(fileName);
            foreach (var FileUpload in ImageFile)
            {
                if (FileUpload.Length > 0)
                {
                    using (var stream = new FileStream(fileName, FileMode.Create))
                    {
                        FileUpload.CopyToAsync(stream);

                    }
                }
            }
            ////brrr
            //if (ModelState.IsValid)
            //{

            //    long size = files.Sum(f => f.Length);

            //    // full path to file in temp location
            //    var filePath = Path.Combine()

            //    foreach (var formFile in files)
            //    {
            //        if (formFile.Length > 0)
            //        {
            //            using (var stream = new FileStream(filePath, FileMode.Create))
            //            {
            //                await formFile.CopyToAsync(stream);
            //            }

            //        }

            /////brrrrrrr
            //if (ImageUrl != null)
            //
            // var ImagePath = Path.GetFileNameWithoutExtension();
            //    if (ImageUrl.Length>0)
            //    {
            //        using (var stream = new FileStream(ImagePath, FileMode.Create))
            //        {
            //            ImageUrl.CopyTo(stream);
            //        }
            //    }
            //var url = Path.Combine("~/AItem/" + obj.signUp.SignUpId + obj.itemCategory.ItemCategoryId + obj.ItemId);
            //var directory = new DirectoryInfo(url);

            //if (directory.Exists == false)
            //{
            //    directory.Create();
            //}

            //using (var stream = new FileStream(url, FileMode.Create))
            //{
            //    ImageUrl.CopyTo(stream);
            //}


            //obj.ImageUrl =Convert.ToString(ImageUrl);

            var itemcategoryid = HttpContext.Request.Form["ItemCategoryId"].ToString();
            obj.ItemCategoryId = Convert.ToInt32(itemcategoryid);

            _itemData.AddItem(obj);
             return RedirectToAction("ItemList", "Item", new { id = id});
                
            
            
        }

        // GET: Item/Edit/5
        [HttpGet]
        public ActionResult Edit(int id, int edit)
        {
            TempData["id"] = id;
            return View(_itemData.EditItemId(edit));
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemDTO obj, int id)
        {
            if (ModelState.IsValid)
            {


                try
                {
                    // TODO: Add update logic here
                    _itemData.EditedItem(obj);
                    return RedirectToAction("Index", "Shop", new { id = id});
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
            return View();
        }

        // GET: Item/Delete/5
        [HttpGet]
        public ActionResult Delete(int id, int delete)
        {
            TempData["id"] = id;
            return View(_itemData.GetDeleteItem(delete));
        }

        // POST: Item/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteData(int ItemId, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    _itemData.Delete(ItemId);
                    return RedirectToAction("Index", "Shop", new { id = id});
                }
                catch
                {
                    throw;
                }
            }
            return View();
        }
    }
}