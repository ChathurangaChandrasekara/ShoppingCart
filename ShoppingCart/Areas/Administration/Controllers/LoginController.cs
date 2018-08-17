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
    public class LoginController : Controller
    {
        public ILoginData _loginData;
        public LoginController(ILoginData loginData)
        {
            _loginData = loginData;    
        }
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDTO obj)
        { 
            if (ModelState.IsValid)
            {
                string message = "";
                
            LoginMessaageDTO loginobj =   _loginData.checkLogin(obj);
                message = loginobj.Message;
                string email = loginobj.Email;
                ViewBag.message = message;
                if (loginobj.LoginType== "Error")
                {
                    return View();
                }
                else if (loginobj.LoginType=="User")
                {
                    return RedirectToAction("Index", "User", new { area = "User" });
                }
                else if (loginobj.LoginType == "Shop" && loginobj.Active== true)
                {
                    return RedirectToAction("Index", "Shop", new { area = "Shop", Id = email });
                }
                else if (loginobj.LoginType == "Shop" && loginobj.Active == null)
                {
                    return RedirectToAction("WaitActiveRequest", "Login", new { area = "Administration" });
                }
                else if (loginobj.LoginType == "Admin")
                {
                    return RedirectToAction("Index", "Admin", new { area = "Administration" });
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
        
        

        
       

        public IActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpDTO obj)
        {
            //check whether validation true or false
            if (ModelState.IsValid)
            {
                //check that there has server error
                try
                {
                   
                    _loginData.setAllLoginData(obj);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return View();
        }

        public ActionResult WaitActiveRequest()
        {
            return View();
        }
    }
}