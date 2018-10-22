using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Models;

namespace ShoppingCart.Areas.Administration.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ShoppingCartDbContext _db;

        public ILoginData _loginData;

        public LoginController( ShoppingCartDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ILoginData loginData)
        {
           _userManager = userManager;
           _signInManager = signInManager;
           _loginData = loginData;
            _db = db;
        }
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO obj)
        { 
            if (ModelState.IsValid)
            {
                string message = "";

                //LoginMessaageDTO loginobj = await _loginData.checkLoginAsync(obj);

                LoginMessaageDTO msgObj = new LoginMessaageDTO();
                //var user = await _userManager.FindByNameAsync(obj.Email);
                //if (user != null)
                //{
                //    var result = await _signInManager.PasswordSignInAsync(user, obj.Password, false, false);
                //    if (result.Succeeded)
                //    {

                if (_db.SignUps.Where(x => x.Email == obj.Email && x.Password == obj.Password).Any())
                {
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, obj.Email));
                    identity.AddClaim(new Claim(ClaimTypes.Name, obj.Email));
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = obj.RememberMe });
                    


                    string LoginType = _db.SignUps.Where(x => x.Email == obj.Email).Select(x => x.LoginType).FirstOrDefault();
                        bool? Active = _db.SignUps.Where(x => x.Email == obj.Email).Select(x => x.Active).FirstOrDefault();
                        int Id = _db.SignUps.Where(x => x.Email == obj.Email).Select(x => x.SignUpId).FirstOrDefault();
                        if (LoginType == "User")
                        {
                            msgObj.Id = Id;
                            msgObj.Email = obj.Email;
                            msgObj.Message = "user login";
                            msgObj.LoginType = "User";
                        }
                        else if (LoginType == "Shop")
                        {
                            msgObj.Id = Id;
                            msgObj.Active = Active;
                            msgObj.Email = obj.Email;
                            msgObj.Message = "Shop login";
                            msgObj.LoginType = "Shop";
                        }
                        else
                        {
                            msgObj.Id = Id;
                            msgObj.Email = obj.Email;
                            msgObj.Message = "Admin login";
                            msgObj.LoginType = "Admin";
                        }
                        }
                //    }
                //}
                else if (_db.SignUps.Where(x => x.Email == obj.Email || x.Password == obj.Password).Any())
                {
                    if (_db.SignUps.Where(x => x.Email == obj.Email).Any())
                    {
                        msgObj.Message = "Password is incorrect";
                        msgObj.LoginType = "Error";
                    }
                    else
                    {
                        msgObj.Message = "Email is incorrect";
                        msgObj.LoginType = "Error";
                    }
                }
                else
                {
                    msgObj.Message = "user name And Email is incorrect";
                    msgObj.LoginType = "Error";
                }

                message = msgObj.Message;
                string email = msgObj.Email;
                int id = msgObj.Id;
                ViewBag.message = message;
                if (msgObj.LoginType== "Error")
                {
                    return View();
                }
                else if (msgObj.LoginType=="User")
                {
                    return RedirectToAction("Details", "User", new { area = "User" , Id = id});
                }
                else if (msgObj.LoginType == "Shop" && msgObj.Active== true)
                {
                    
                    return RedirectToAction("Index", "Shop", new { area = "Shop", Id = id });
                }
                else if (msgObj.LoginType == "Shop" && msgObj.Active == null)
                {
                    return RedirectToAction("WaitActiveRequest", "Login", new { area = "Administration" });
                }
                else if (msgObj.LoginType == "Admin")
                {
                    return RedirectToAction("Index", "Admin", new { area = "Administration" ,Id = id});
                }
                else
                {
                    return View();
                }
            }
            return RedirectToAction("Login","Login", new { Areas = "Administration"});
        }
        
        

        
       

        public IActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpDTO obj)
        {
            //check whether validation true or false
            if (ModelState.IsValid)
            {
                //check that there has server error
                try
                {
                    var user = new IdentityUser() { UserName = obj.Email };
                    var result = await _userManager.CreateAsync(user, obj.Password);

                    if (result.Succeeded)
                    {
                       // _loginData.setAllLoginData(obj);
                        return RedirectToAction("Login", "Login", new { area = "Administration" });
                    }
                }
                catch (DbUpdateConcurrencyException e)
                {

                    throw new Exception($"Sign up doesn't occure", e );
                }
            }
            return View();
        }

        public ActionResult WaitActiveRequest()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Home", "Home", new { area = "Home" });
        }
    }
}