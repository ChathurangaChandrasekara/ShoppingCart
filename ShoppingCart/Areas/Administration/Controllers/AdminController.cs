using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;

namespace ShoppingCart.Areas.Administration.Controllers
{
    public class AdminController : Controller
    {
        public IAdminData _adminData;
        public AdminController(IAdminData adminData)
        {
            _adminData = adminData;
        }


        // GET: Admin
        public ActionResult Index()
        {
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
                    return RedirectToAction("EditUser", "Admin");
                }
                catch (Exception ex)
                {

                    throw;
                }
               
            }
            return View();
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

        //// GET: Admin/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Admin/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

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
    }
}