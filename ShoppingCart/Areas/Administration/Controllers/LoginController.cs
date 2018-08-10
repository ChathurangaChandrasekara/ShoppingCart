﻿using System;
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
                ViewBag.message = message;
                if (loginobj.LoginType== "Error")
                {
                    return View();
                }
                else if (loginobj.LoginType=="User")
                {
                    return RedirectToAction("Index", "User", new { area = "User" });
                }
                else if (loginobj.LoginType == "Shop")
                {
                    return RedirectToAction("Index", "Shop", new { area = "Shop" });
                }
                else if (loginobj.LoginType == "Admin")
                {
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
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
    }
}