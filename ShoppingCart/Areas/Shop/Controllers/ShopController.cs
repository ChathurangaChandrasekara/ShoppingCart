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
using ShoppingCart.Areas.Shop.ShopViewModels;
using ShoppingCart.Models;

namespace ShoppingCart.Areas.Shop.Controllers
{
    public class ShopController : Controller
    {
        private ShoppingCartDbContext _db;
        private IHostingEnvironment _hostingEnvironment;
        public IShopData _shopData;
        MainShopViewModel mainShopViewModel;
        public ShopController(IShopData shopData, IHostingEnvironment hostingEnvironment, ShoppingCartDbContext db)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            _shopData = shopData;
            mainShopViewModel = new MainShopViewModel();
        }


        // ******* View Shop Details ********
        [HttpGet]
        public ActionResult Index(int id)
        {
            TempData["id"] = id;
            
            mainShopViewModel.signUpDetails = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();

            mainShopViewModel.moreDetail = _db.MoreDetails.Where(x => x.SignUpId == id).FirstOrDefault();

            mainShopViewModel.CategoryList = _db.ItemCategories.Where(x => x.SignUpId == id).ToList();

            List<Item> ListItem = _db.Items.Where(x => x.SignUpId == id).ToList();
            List<ItemDTO> itemDTOs = new List<ItemDTO>();
            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                itemDTOs.Add(obj);
            }
            mainShopViewModel.items = itemDTOs;
            return View(mainShopViewModel); 
        }

        public ActionResult CategoryListItem (int id)
        {
            List<Item> categoryListItem = _db.Items.Where(x => x.ItemCategoryId == id).ToList();
            List<ItemDTO> itemDTOs = new List<ItemDTO>();
            foreach (var item in categoryListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                itemDTOs.Add(obj);
            }
            return View(itemDTOs);

        }
        

        //add more detail if they are not
        public ActionResult CheckMoreDetail(int id)
        {
            TempData["id"] = id;
            if (_db.MoreDetails.Any(x => x.SignUpId == id))
            {
                //int getid = _db.MoreDetails.Where(x => x.SignUpId == id).Select(x => x.MoreDetailId).FirstOrDefault();
                return RedirectToAction("ShowAllDetail", "Shop", new {id = id });
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
                //filename = this.EnsureFilename(filename);

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
            string path = _hostingEnvironment.WebRootPath + "\\shopImages\\" + id + "\\ShopLogo\\";
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
                //var filepath = Path.GetTempFileName();

                //foreach (IFormFile item in files)
                //{
                //    string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                //    filename = this.EnsureFilename(filename);

                //    using (FileStream filestream = System.IO.File.Create(this.Getpath(filename, id)))
                //    {
                //        obj.ImageUrl = filename;
                //    }

                //}
                
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

       public ActionResult ViewByCategory(int id)
        {

            return null;
        }

        
    }
}