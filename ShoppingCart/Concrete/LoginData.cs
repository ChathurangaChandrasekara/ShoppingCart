using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class LoginData : ILoginData
    {
        private readonly ShoppingCartDbContext _db;

        public LoginData(ShoppingCartDbContext db)
        {
            _db = db;
        }

        public LoginMessaageDTO checkLogin(LoginDTO loginobj)
        {
            LoginMessaageDTO msgObj = new LoginMessaageDTO();
            if (_db.SignUps.Where(x=>x.Email==loginobj.Email && x.Password==loginobj.Password).Any())
            {
                string LoginType = _db.SignUps.Where(x => x.Email == loginobj.Email).Select(x => x.LoginType).FirstOrDefault();
                bool? Active = _db.SignUps.Where(x => x.Email == loginobj.Email).Select(x => x.Active).FirstOrDefault();
                int Id = _db.SignUps.Where(x => x.Email == loginobj.Email).Select(x => x.SignUpId).FirstOrDefault();
                if (LoginType == "User")
                {
                    msgObj.Id = Id;
                    msgObj.Email = loginobj.Email;
                    msgObj.Message = "user login";
                    msgObj.LoginType = "User";
                }
                else if(LoginType == "Shop")
                {
                    msgObj.Id = Id;
                    msgObj.Active = Active;
                    msgObj.Email = loginobj.Email;
                    msgObj.Message = "Shop login";
                    msgObj.LoginType = "Shop";
                }
                else
                {
                    msgObj.Email = loginobj.Email;
                    msgObj.Message = "Admin login";
                    msgObj.LoginType = "Admin";
                }
            }
            else if(_db.SignUps.Where(x => x.Email == loginobj.Email || x.Password == loginobj.Password).Any())
            {
                if (_db.SignUps.Where(x => x.Email == loginobj.Email).Any())
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
            return msgObj;
        }

        public List<SignUpDTO> getAllLoginData()
        {
            List<SignUpDTO> resultList = new List<SignUpDTO>();
            List<SignUp> listSigunups = _db.SignUps.ToList();

            foreach (var item in listSigunups)
            {
                SignUpDTO obj = new SignUpDTO();

                obj.Active = item.Active;
                obj.Address = item.Address;
                obj.Email = item.Email;
                obj.FullName = item.FullName;
                obj.LoginType = item.LoginType;
                obj.Password = item.Password;
                obj.PhoneNumber = item.PhoneNumber;
                obj.SignUpId = item.SignUpId;

                resultList.Add(obj);
            }

            return resultList;
        }

        public void setAllLoginData(SignUpDTO signobj)
        {
            
            try
            {
                SignUp obj = new SignUp();
                obj.Address = signobj.Address;
                obj.Email = signobj.Email;
                obj.FullName = signobj.FullName;
                obj.LoginType = signobj.LoginType;
                obj.Password = signobj.Password;
                obj.PhoneNumber = signobj.PhoneNumber;
                
                if (obj.LoginType =="User")
                {
                    obj.Active = true;
                }
                else
                {
                    obj.Active = false;
                }
                _db.SignUps.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
           

        }
    }
}
