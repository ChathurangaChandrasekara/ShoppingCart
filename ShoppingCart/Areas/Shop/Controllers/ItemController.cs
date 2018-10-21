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
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;

namespace ShoppingCart.Areas.Shop.Controllers
{
    public class ItemController : Controller
    {
        ShoppingCartDbContext _db;
        private IHostingEnvironment _hostingEnvironment;

        public IItemData _itemData;
        public ItemController(IItemData itemData, ShoppingCartDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _itemData = itemData;
            _db = db;
            _hostingEnvironment = hostingEnvironment;

        }
        // GET: Item
        public ActionResult ItemDetail(int id)
        {
            return View(_itemData.Details(id));
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
        public ActionResult CreateItem(int id)
        {
            TempData["id"] = id;
            List<ItemCategory> itemCategorieslist = new List<ItemCategory>();
            itemCategorieslist = (from itemcategory in _db.ItemCategories.Where(x => x.SignUpId == 7 || x.SignUpId==id) select itemcategory).ToList();
            itemCategorieslist.Insert(0, new ItemCategory { ItemCategoryId = 0, ItemCategoryName = "Select" });
            ViewBag.ListItemCategory = itemCategorieslist;

            return View();
            
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateItem(ItemDTO obj, IFormFile files1, IFormFile files2, IFormFile files3, IFormFile files4, int id)
        {
            var itemcategoryid = HttpContext.Request.Form["ItemCategoryId"].ToString();
            obj.ItemCategoryId = Convert.ToInt32(itemcategoryid);

            if (ModelState.IsValid)
            {
                

                //First Image ///////////////////////////////////////////////////
                if (files1 != null)
                {
                    var filepath = Path.GetTempFileName();
                    string filename = ContentDispositionHeaderValue.Parse(files1.ContentDisposition).FileName.Trim('"');
                    filename = this.EnsureFilename(filename);

                    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                    {
                        files1.CopyToAsync(filestream);
                        obj.ImageUrl1 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                        
                    }
                }
                //Second Image ////////////////////////////////////////////////
                if (files2 != null)
                {
                    var filepath = Path.GetTempFileName();
                    string filename = ContentDispositionHeaderValue.Parse(files2.ContentDisposition).FileName.Trim('"');
                    filename = this.EnsureFilename(filename);

                    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                    {
                        files2.CopyToAsync(filestream);
                        obj.ImageUrl2 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                    }
                }
                //Third image /////////////////////////////////////////////////
                if (files3 != null)
                {
                    var filepath = Path.GetTempFileName();
                    string filename = ContentDispositionHeaderValue.Parse(files3.ContentDisposition).FileName.Trim('"');
                    filename = this.EnsureFilename(filename);

                    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                    {
                        files3.CopyToAsync(filestream);
                        obj.ImageUrl3 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                    }
                }
                //Fourth Image ///////////////////////////////////////////////
                if (files4 != null)
                {
                    var filepath = Path.GetTempFileName();
                    string filename = ContentDispositionHeaderValue.Parse(files4.ContentDisposition).FileName.Trim('"');
                    filename = this.EnsureFilename(filename);

                    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                    {
                        files4.CopyToAsync(filestream);
                        obj.ImageUrl4 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                    }
                }
                //foreach (IFormFile item in files)
                //{
                //    string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                //    filename = this.EnsureFilename(filename);

                //    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                //    {
                //        item.CopyToAsync(filestream);
                //        obj.ImageUrl1 = filename;
                //    }

                //}
                //Second Image ///////////////////////////////////////////////////
                //foreach (IFormFile item in files)
                //{
                //    string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                //    //filename = this.EnsureFilename(filename);

                //    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                //    {
                //        item.CopyToAsync(filestream);
                //    }
                //    obj.ImageUrl2 = filename;
                //}
                //// Third Image ///////////////////////////////////////////////////
                //foreach (IFormFile item in files)
                //{
                //    string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                //    //filename = this.EnsureFilename(filename);

                //    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                //    {
                //        item.CopyToAsync(filestream);
                //    }
                //    obj.ImageUrl3 = filename;
                //}
                ////Fourth Image /////////////////////////////////////////////////
                //foreach (IFormFile item in files)
                //{
                //    string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                //    filename = this.EnsureFilename(filename);

                //    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id,obj)))
                //    {
                //        item.CopyToAsync(filestream);
                //    }
                //    obj.ImageUrl4 = filename;
                //}
                try
                {
                    _itemData.AddItem(obj);
                    return RedirectToAction("ItemList", "Item", new { id = id });
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View();
         
        }
        private string Getpath(string filename, int id, ItemDTO obj)
        {
            string path = _hostingEnvironment.WebRootPath + "\\itemImages\\" + obj.ItemCategoryId +"\\"+ obj.SignUpId +"\\" +obj.ItemName + "\\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path + filename;

        }
        private string EnsureFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;


        }

        // GET: Item/Edit/5
        [HttpGet]
        public ActionResult Edit(int id, int edit)
        {
            TempData["id"] = id;
            List<ItemCategory> itemCategorieslist = new List<ItemCategory>();
            itemCategorieslist = (from itemcategory in _db.ItemCategories.Where(x => x.SignUpId == 7 || x.SignUpId == id) select itemcategory).ToList();
            itemCategorieslist.Insert(0, new ItemCategory { ItemCategoryId = 0, ItemCategoryName = "Select" });
            ViewBag.ListItemCategory = itemCategorieslist;
            return View(_itemData.EditItemId(edit));
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemDTO obj,IFormFile files1, IFormFile files2, IFormFile files3, IFormFile files4, int id)
        {
            var itemcategoryid = HttpContext.Request.Form["ItemCategoryId"].ToString();
            obj.ItemCategoryId = Convert.ToInt32(itemcategoryid);

            if (ModelState.IsValid)
            {
                try
                {
                    if (files1 != null)
                    {
                        var selectImageUrl = _db.Items.Where(x => x.ItemId == obj.ItemId).Select(x => x.ImageUrl1).SingleOrDefault();
                        var completepath = _hostingEnvironment.WebRootPath + "\\itemImages\\" + obj.ItemCategoryId  + selectImageUrl;
                        if (System.IO.File.Exists(completepath))
                        {
                            System.IO.File.Delete(completepath);
                           
                        }

                        var filepath = Path.GetTempFileName();
                        string filename = ContentDispositionHeaderValue.Parse(files1.ContentDisposition).FileName.Trim('"');
                        filename = this.EnsureFilename(filename);

                        using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                        {
                            files1.CopyToAsync(filestream);
                            obj.ImageUrl1 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;

                        }
                    }
                    //Second Image ////////////////////////////////////////////////
                    if (files2 != null)
                    {
                        var selectImageUrl = _db.Items.Where(x => x.ItemId == obj.ItemId).Select(x => x.ImageUrl2).SingleOrDefault();
                        var completepath = _hostingEnvironment.WebRootPath + "\\itemImages\\" + obj.ItemCategoryId + selectImageUrl;
                        if (System.IO.File.Exists(completepath))
                        {
                            System.IO.File.Delete(completepath);

                        }
                        var filepath = Path.GetTempFileName();
                        string filename = ContentDispositionHeaderValue.Parse(files2.ContentDisposition).FileName.Trim('"');
                        filename = this.EnsureFilename(filename);

                        using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                        {
                            files2.CopyToAsync(filestream);
                            obj.ImageUrl2 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                        }
                    }
                    //Third image /////////////////////////////////////////////////
                    if (files3 != null)
                    {
                        var selectImageUrl = _db.Items.Where(x => x.ItemId == obj.ItemId).Select(x => x.ImageUrl3).SingleOrDefault();
                        var completepath = _hostingEnvironment.WebRootPath + "\\itemImages\\" + obj.ItemCategoryId + selectImageUrl;
                        if (System.IO.File.Exists(completepath))
                        {
                            System.IO.File.Delete(completepath);

                        }
                        var filepath = Path.GetTempFileName();
                        string filename = ContentDispositionHeaderValue.Parse(files3.ContentDisposition).FileName.Trim('"');
                        filename = this.EnsureFilename(filename);

                        using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                        {
                            files3.CopyToAsync(filestream);
                            obj.ImageUrl3 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                        }
                    }
                    //Fourth Image ///////////////////////////////////////////////
                    if (files4 != null)
                    {
                        var selectImageUrl = _db.Items.Where(x => x.ItemId == obj.ItemId).Select(x => x.ImageUrl4).SingleOrDefault();
                        var completepath = _hostingEnvironment.WebRootPath + "\\itemImages\\" + obj.ItemCategoryId + selectImageUrl;
                        if (System.IO.File.Exists(completepath))
                        {
                            System.IO.File.Delete(completepath);

                        }
                        var filepath = Path.GetTempFileName();
                        string filename = ContentDispositionHeaderValue.Parse(files4.ContentDisposition).FileName.Trim('"');
                        filename = this.EnsureFilename(filename);

                        using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id, obj)))
                        {
                            files4.CopyToAsync(filestream);
                            obj.ImageUrl4 = "\\" + obj.SignUpId + "\\" + obj.ItemName + "\\" + filename;
                        }
                    }
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
        public ActionResult Delete(int id, int delete, int categoryid)
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
                    var categoryId = _db.Items.Where(x => x.ItemId == ItemId).Select(x => x.ItemCategoryId).SingleOrDefault();
                    var itemName = _db.Items.Where(x => x.ItemId == ItemId).Select(x => x.ItemName).SingleOrDefault();
                    var completepath = _hostingEnvironment.WebRootPath + "\\itemImages\\" + categoryId + "\\" + id +"\\"+ itemName +"\\";
                    if (System.IO.File.Exists(completepath))
                    {
                        System.IO.File.Delete(completepath);

                    }

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