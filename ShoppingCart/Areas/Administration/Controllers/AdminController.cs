using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Areas.Shop.Models;

namespace ShoppingCart.Areas.Administration.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ILoginData _loginData;
        IAdminData _adminData;
        IItemCategoryData _itemCategoryData;
        public AdminController(IAdminData adminData,ILoginData loginData, IItemCategoryData itemCategoryData)
        {
            _itemCategoryData = itemCategoryData;
            _adminData = adminData;
            _loginData = loginData;
        }


        // GET: Admin
        public ActionResult Index(int id)
        {
            TempData["id"] = id;
            return View();
        }

        // search Active Shop ******
        [HttpGet]
        public ActionResult Active()
        {
            return View(_adminData.GetActiveShop());
        }

        
        [HttpPost]
        public ActionResult Active(string search)
        {
            return View(_adminData.SearchActiveShop(search));
        }

        // search Pending Shop ******
        [HttpGet]
        public ActionResult PendingShop()
        {
            return View(_adminData.GetPendingShop());
        }

        
        [HttpPost]
        public ActionResult PendingShop(string search)
        {
            return View(_adminData.SearchPendingShop(search));
        }

        // User Search ******
        [HttpGet]
        public ActionResult GetUser()
        {
            return View(_adminData.GetUser());
        }
        
        [HttpPost]
        public ActionResult GetUser(string search)
        {
            return View(_adminData.SearchUser(search));
        }

        //Edit active shop sign up details ******
        [HttpGet]
        public ActionResult EditShop(int id)
        {
            
            return View(_adminData.EditDetailsId(id));
        }

        [HttpPost]
        public ActionResult EditShop(SignUpDTO obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _adminData.EditDetails(obj);
                    return RedirectToAction("Active", "Admin");
                }
                catch (Exception ex)
                {

                    throw;
                }
               
            }
            return View();
        }
        //Edit pending shop sign up datails ******
        [HttpGet]
        public ActionResult EditPendingShop(int id)
        {

            return View(_adminData.EditDetailsId(id));
        }

        [HttpPost]
        public ActionResult EditPendingShop(SignUpDTO obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _adminData.EditDetails(obj);
                    return RedirectToAction("PendingShop", "Admin");
                }
                catch (Exception ex)
                {

                    throw;
                }
               
            }
            return View();
        }
        //Edit user sign up details ******
        [HttpGet]
        public ActionResult EditUser(int id)
        {

            return View(_adminData.EditDetailsId(id));
        }

        [HttpPost]
        public ActionResult EditUser(SignUpDTO obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _adminData.EditDetails(obj);
                    return RedirectToAction("GetUser", "Admin");
                }
                catch (Exception ex)
                {

                    throw;
                }
               
            }
            return View();
        }

        [HttpGet]
        public ActionResult UserDetail(int id)
        {
            return View(_adminData.GetUserDetails(id));
        }



        //// POST: Admin/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Admin/Edit/5
        [HttpGet]
        public ActionResult Create(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SignUpDTO obj, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _loginData.setAllLoginData(obj);
                    if (obj.LoginType=="Shop" && obj.Active==true)
                    {
                        return RedirectToAction("Active", "Admin");
                    }
                    else if (obj.LoginType == "Shop" && obj.Active == null || false)
                    {
                        return RedirectToAction("PendingShop", "Admin");
                    }
                    else if(obj.LoginType == "User")
                    {
                        return RedirectToAction("GetUser", "Admin");
                    }

                }
                catch(Exception ex)
                {
                    throw;
                }
            }
            return View();
        }

        // Delete details 
        public ActionResult Delete(int id)
        {
            return View(_adminData.DeleteDetailsId(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _adminData.DeleteDetails(id);
                return RedirectToAction("Index","Admin");
            }
            catch
            {
                return View();
            }
        }

        //Admin Can Access to All Category 
        public ActionResult AdminCategoryList(int id)
        {
            id = 7;
            TempData["id"] = id;
            return View(_itemCategoryData.AdminShowList());
        }

        public ActionResult AdminCategoryCreate(int id)
        {
            id = 7;
            TempData["id"] = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminCategoryCreate(ItemCategoryDTO obj, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _itemCategoryData.Created(obj);
                    return RedirectToAction("AdminCategoryList", "Admin", new { id = id });
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
        public ActionResult AdminCategoryEdit(int edit, int id)
        {
            TempData["id"] = id;
            return View(_itemCategoryData.EditById(edit));
        }

        // POST: ItemCategory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminCategoryEdit(ItemCategoryDTO obj, int id)
        {
            TempData["id"] = id;
            if (ModelState.IsValid)
            {
                try
                {
                    _itemCategoryData.Edited(obj);
                    return RedirectToAction("AdminCategoryList", "Admin", new { id = id });
                }
                catch
                {
                    throw;
                }
            }
            return View();
        }

        //Delete Category///////////////
        [HttpGet]
        public ActionResult AdminCategoryDelete(int delete, int id)
        {
            TempData["delete"] = delete;
            TempData["id"] = id;
            return View(_itemCategoryData.DeleteById(delete, id));
        }

        // POST: ItemCategory/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("AdminCategoryDelete")]
        public ActionResult DeleteDAdminCategoryDeleteData(int ItemCategoryId, int SignUpId)
        {
            try
            {
                _itemCategoryData.Deleted(ItemCategoryId, SignUpId);
                    return RedirectToAction("AdminCategoryList", "Admin", new { id = SignUpId });
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}