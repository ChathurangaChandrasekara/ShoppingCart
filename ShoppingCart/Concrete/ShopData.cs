using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class ShopData : IShopData
    {
        private readonly ShoppingCartDbContext _db;
        public ShopData(ShoppingCartDbContext db)
        {
            _db = db;
        }

        public void EditAllShopDetail(MoreDetailDTO obj)
        {
            MoreDetail SaveMoreDetail = _db.MoreDetails.Where(x => x.MoreDetailId == obj.MoreDetailId).FirstOrDefault();
            SaveMoreDetail.AdditionAddress = obj.AdditionAddress;
            SaveMoreDetail.AdditionPhoneNumber = obj.AdditionPhoneNumber;
            SaveMoreDetail.ImageUrl = obj.ImageUrl;
            SaveMoreDetail.Location = obj.Location;
            SaveMoreDetail.MoreDetailId = obj.MoreDetailId;

            _db.Entry(SaveMoreDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            
        }

        public SignUpDTO ShopDetailId(string id)
        {
            SignUpDTO ViewSignUpShopData = new SignUpDTO();
            int Id = _db.SignUps.Where(x => x.Email == id).Select(x => x.SignUpId).FirstOrDefault();
            SignUp ShopSignUpData = _db.SignUps.Where(x => x.SignUpId == Id).FirstOrDefault();



            ViewSignUpShopData.FullName = ShopSignUpData.FullName;
            ViewSignUpShopData.Active = ShopSignUpData.Active;
            ViewSignUpShopData.LoginType = ShopSignUpData.LoginType;
            ViewSignUpShopData.Password = ShopSignUpData.Password;
            ViewSignUpShopData.SignUpId = ShopSignUpData.SignUpId;
            ViewSignUpShopData.Email = ShopSignUpData.Email;
            ViewSignUpShopData.PhoneNumber = ShopSignUpData.PhoneNumber;
            ViewSignUpShopData.Address = ShopSignUpData.Address;


            return ViewSignUpShopData;


        }
    }
}
