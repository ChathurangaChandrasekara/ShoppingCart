using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Areas.Home.ViewModels;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Areas.Shop.ShopViewModels;
using ShoppingCart.Models;

namespace ShoppingCart.Areas.Home.Controllers
{
    public class HomeController : Controller
    {
        ShoppingCartDbContext _db;
        HomeViewModel homeViewModel;
        MainShopViewModel mainShopViewModel;
        public HomeController(ShoppingCartDbContext db)
        {
            homeViewModel = new HomeViewModel();
            _db = db;
            mainShopViewModel = new MainShopViewModel();
        }

        [HttpGet]
        public ActionResult Shop(int id)
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


       

        public ActionResult Item(int id)
        {
            Item getItem = _db.Items.Where(x => x.ItemId == id).FirstOrDefault();
            ItemDTO obj = new ItemDTO();
            obj.Description = getItem.Description;
            obj.ImageUrl1 = getItem.ImageUrl1;
            obj.ImageUrl2 = getItem.ImageUrl2;
            obj.ImageUrl3 = getItem.ImageUrl3;
            obj.ImageUrl4 = getItem.ImageUrl4;
            obj.ItemCategoryId = getItem.ItemCategoryId;
            obj.ItemCode = getItem.ItemCode;
            obj.ItemId = getItem.ItemId;
            obj.ItemName = getItem.ItemName;
            obj.Quantity = getItem.Quantity;
            obj.UnitPrice = getItem.UnitPrice;
            obj.SignUpId = getItem.SignUpId;

            return View(obj);
        }

        public ActionResult Home()
        {
            homeViewModel.ShopList = _db.SignUps.Where(x => x.LoginType == "Shop" && x.Active == true).ToList();
           
            List<int> categoryId = _db.ItemCategories.Select(x => x.ItemCategoryId).ToList();

            homeViewModel.Length = categoryId.Count *4;
            
            foreach (var category in categoryId)
            {
                List<ItemDTO> ItemListData1 = new List<ItemDTO>();
                List<Item> ListItem1 = _db.Items.Where(x => x.ItemCategoryId == category).Take(4).ToList();
                if (ListItem1 != null)
                {
                    homeViewModel.Category.Add(category);
                    homeViewModel.ListCategory.Add(_db.ItemCategories.Where(x => x.ItemCategoryId == category).FirstOrDefault());
                    foreach (var item in ListItem1)
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


                            ItemListData1.Add(obj);
                    
                        }
                    
                }

                homeViewModel.ItemList.AddRange(ItemListData1);
            }
            return View(homeViewModel);
        }

    }
}