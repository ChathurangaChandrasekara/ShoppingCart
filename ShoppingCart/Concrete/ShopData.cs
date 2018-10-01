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

        public void AddMoreShopDetail(MoreDetailDTO obj)
        {
            MoreDetail SaveMoreDetail = new MoreDetail();

            SaveMoreDetail.AdditionAddress = obj.AdditionAddress;
            SaveMoreDetail.AdditionPhoneNumber = obj.AdditionPhoneNumber;
            SaveMoreDetail.ImageUrl = obj.ImageUrl;
            SaveMoreDetail.Location = obj.Location;
            SaveMoreDetail.SignUpId = obj.SignUpId;

            _db.MoreDetails.Add(SaveMoreDetail);
            _db.SaveChanges();
            
        }

        public SignUpDTO ShopDetailId(int id)
        {
            SignUpDTO ViewSignUpShopData = new SignUpDTO();
            SignUp ShopSignUpData = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();

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

        public AllDataDTO MoreDetailId(int id)
        {
            SignUp SData = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();
            MoreDetail Mdata = _db.MoreDetails.Where(x => x.SignUpId == id).FirstOrDefault();
            AllDataDTO AllData = new AllDataDTO();

            AllData.FullName = SData.FullName;
            AllData.Address = SData.Address;
            AllData.Email = SData.Email;
            AllData.PhoneNumber = SData.PhoneNumber;
            AllData.LoginType = SData.LoginType;
            AllData.AdditionAddress = Mdata.AdditionAddress;
            AllData.AdditionPhoneNumber = Mdata.AdditionPhoneNumber;
            AllData.Location = Mdata.Location;
            AllData.ImageUrl = Mdata.ImageUrl;
            AllData.MoreDetailId = Mdata.MoreDetailId;
            AllData.SignUpId = Mdata.SignUpId;


            return AllData;
        }

        public void EditedDetail(AllDataDTO obj)  //how to save data into 2 table from one view
        {
            SignUp SData = _db.SignUps.Where(x => x.SignUpId == obj.SignUpId).FirstOrDefault();
            MoreDetail Mdata = _db.MoreDetails.Where(x => x.SignUpId == obj.SignUpId).FirstOrDefault();
           

            SData.FullName = obj.FullName;
            SData.Address = obj.Address;
            SData.Email = obj.Email;
            SData.PhoneNumber = obj.PhoneNumber;
            SData.LoginType = obj.LoginType;
            Mdata.AdditionAddress = obj.AdditionAddress;
            Mdata.AdditionPhoneNumber = obj.AdditionPhoneNumber;
            Mdata.Location = obj.Location;
            Mdata.ImageUrl = obj.ImageUrl;

            _db.SignUps.Update(SData);
            _db.MoreDetails.Update(Mdata); //.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public AllDataDTO ShowAllDetail(int id)
        {
            SignUp SData = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();
            MoreDetail Mdata = _db.MoreDetails.Where(x => x.SignUpId==id ).FirstOrDefault();
            AllDataDTO AllData = new AllDataDTO();

            AllData.FullName = SData.FullName;
            AllData.Address = SData.Address;
            AllData.Email = SData.Email;
            AllData.PhoneNumber = SData.PhoneNumber;
            AllData.LoginType = SData.LoginType;
            AllData.AdditionAddress = Mdata.AdditionAddress;
            AllData.AdditionPhoneNumber = Mdata.AdditionPhoneNumber;
            AllData.Location = Mdata.Location;
            AllData.ImageUrl = Mdata.ImageUrl;
            AllData.MoreDetailId = Mdata.MoreDetailId;
            AllData.SignUpId = Mdata.SignUpId;
            return AllData;
        }
    }
}
