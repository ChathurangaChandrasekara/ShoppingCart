using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Models;

namespace ShoppingCart.Areas.User.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        
        private readonly ShoppingCartDbContext _db;
        public IUserData _userData;
        public UserController(IUserData userData, ShoppingCartDbContext db)
        {
            _db = db;
            _userData = userData;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            TempData["id"] = id;
            return View(_userData.GetUserDetail(id));
        }

       
        // GET: User/Edit/5
        public ActionResult EditUser(int id)
        {
            TempData["id"] = id;
            return View(_userData.GetDetailToEdit(id));
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SignUpDTO obj,int id)
        {
            try
            {
                _userData.SaveEditDetail(obj);
                return RedirectToAction("Details","User", new { id = id});
            }
            catch
            {
                return View();
            }
        }

    }
}