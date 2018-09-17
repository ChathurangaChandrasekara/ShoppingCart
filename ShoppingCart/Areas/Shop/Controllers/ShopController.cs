using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;

namespace ShoppingCart.Areas.Shop.Controllers
{
    public class ShopController : Controller
    {
        private ShoppingCartDbContext _db;
        private IHostingEnvironment _hostingEnvironment;
        public IShopData _shopData;
        public ShopController(IShopData shopData, IHostingEnvironment hostingEnvironment, ShoppingCartDbContext db)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            _shopData = shopData;
        }


        // ******* View Shop Details ********
        [HttpGet]
        public ActionResult Index(int id)
        {
            TempData["id"] = id;
            return View(_shopData.ShopDetailId(id));
        }



        //add more detail if they are not
        public ActionResult CheckMoreDetail(int id)
        {
            TempData["id"] = id;
            if (_db.MoreDetails.Any(x => x.SignUpId == id))
            {
                //int getid = _db.MoreDetails.Where(x => x.SignUpId == id).Select(x => x.MoreDetailId).FirstOrDefault();
                return RedirectToAction("EditMoreDetail", "Shop", new {id = id });
            }
            else
                return RedirectToAction("AddMoreDetail", "Shop", new { id = id });
           
        }

        // GET: Shop/Edit/5
        [HttpGet]
        public ActionResult AddMoreDetail(int id)
        {
            TempData["id"] = id;
            return View();
        }

        // POST: Shop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMoreDetail(MoreDetailDTO obj,IList<IFormFile> files, int id)
            {
            if (ModelState.IsValid)
            {
           var filepath = Path.GetTempFileName();

            foreach (IFormFile item in files)
             {
                string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                filename = this.EnsureFilename(filename);

                using (FileStream filestream = System.IO.File.Create(this.Getpath(filename,id)))
                {
                     item.CopyToAsync(filestream);
                }
                    obj.ImageUrl = filename;
             }

            
                try
                {
                    _shopData.AddMoreShopDetail(obj);
                    return RedirectToAction("Index", "Shop",new { id= id});
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return View();
        }

        //get uploaded image path
        private string Getpath(string filename, int id)
        {
            string path = _hostingEnvironment.WebRootPath + "\\shopImages\\" + id + "\\images\\";
            if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
                return path + filename;
            
        }

        //check uploaded image already available
        private string EnsureFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;

            
        }

        //edit shop more details
        [HttpGet]
        public ActionResult EditMoreDetail(int id, int edit)
        {
            TempData["id"] = edit;
            return View(_shopData.MoreDetailId(edit));
        }

        // POST: Shop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMoreDetail(AllDataDTO obj, IList<IFormFile> files, int id)
        {
            if (ModelState.IsValid)
            {
                var filepath = Path.GetTempFileName();

                foreach (IFormFile item in files)
                {
                    string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                    filename = this.EnsureFilename(filename);

                    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id)))
                    {
                        obj.ImageUrl = filename;
                    }

                }


                try
                {
                    _shopData.EditedDetail(obj);
                    return RedirectToAction("Index", "Shop", new { id = id });
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return View();
        }

        // GET: Shop/
        public ActionResult ShowAllDetail(int id)
        {
            TempData["id"] = id;
            return View(_shopData.ShowAllDetail(id));
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