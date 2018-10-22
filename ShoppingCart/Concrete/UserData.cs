using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class UserData : IUserData
    {
        private readonly ShoppingCartDbContext _db;
        public UserData(ShoppingCartDbContext db)
        {
            _db = db;
        }
        public SignUpDTO GetDetailToEdit(int id)
        {
            SignUp SelectUser = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();
            SignUpDTO GetDetail = new SignUpDTO();

            GetDetail.Address = SelectUser.Address;
            GetDetail.Email = SelectUser.Email;
            GetDetail.FullName = SelectUser.FullName;
            GetDetail.Password = SelectUser.Password;
            GetDetail.PhoneNumber = SelectUser.PhoneNumber;
            GetDetail.SignUpId = SelectUser.SignUpId;
            


            return GetDetail;
        }

        public SignUpDTO GetUserDetail(int id)
        {
            SignUp SelectUser = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();
            SignUpDTO GetDetail = new SignUpDTO();

            GetDetail.Address = SelectUser.Address;
            GetDetail.Email = SelectUser.Email;
            GetDetail.FullName = SelectUser.FullName;
            GetDetail.Password = SelectUser.Password;
            GetDetail.PhoneNumber = SelectUser.PhoneNumber;
            GetDetail.SignUpId = SelectUser.SignUpId;
            

            return GetDetail;
        }

        public void SaveEditDetail(SignUpDTO obj) 
        {
            SignUp SelectUser = _db.SignUps.Where(x => x.SignUpId == obj.SignUpId).FirstOrDefault();

            SelectUser.Address = obj.Address;
            SelectUser.Email = obj.Email;
            SelectUser.FullName = obj.FullName;
            SelectUser.Password = obj.Password;
            SelectUser.PhoneNumber = obj.PhoneNumber;
            SelectUser.SignUpId = obj.SignUpId;

            _db.SignUps.Update(SelectUser);
            _db.SaveChanges();
        }
    }
}
