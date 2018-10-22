using ShoppingCart.Abstract;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class AdminData :IAdminData
    {
        private readonly ShoppingCartDbContext _db;
        public AdminData(ShoppingCartDbContext db)
        {
            _db = db;
        }

       
        public List<SignUpDTO> GetActiveShop()
        {
            List<SignUpDTO> ActiveShopListSignUpDTO = new List<SignUpDTO>();
            List<SignUp> Activeshoplist = _db.SignUps.Where(x => x.Active == true && x.LoginType=="Shop").ToList();
            foreach (var item in Activeshoplist)
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
                ActiveShopListSignUpDTO.Add(obj);
            }

            return ActiveShopListSignUpDTO; ;
        }

        public List<SignUpDTO> GetPendingShop()
        {
            List<SignUpDTO> PendingShopListSignUpDTO = new List<SignUpDTO>();
            List<SignUp> Pendingshoplist = _db.SignUps.Where(x => x.Active == false && x.LoginType=="Shop").ToList();
            foreach (var item in Pendingshoplist)
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
                PendingShopListSignUpDTO.Add(obj);
            }

            return PendingShopListSignUpDTO;

        }

        public List<SignUpDTO> GetUser()
        {
            List<SignUpDTO> UserListSignUpDTO = new List<SignUpDTO>();
            List<SignUp> UserList = _db.SignUps.Where(x => x.LoginType == "User").ToList();
            foreach (var item in UserList)
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
                UserListSignUpDTO.Add(obj);
            }

            return UserListSignUpDTO;
        }

        public List<SignUpDTO> SearchActiveShop(string searchName)
        {
            List<SignUpDTO> SearchActiveShopSignUpDTO = new List<SignUpDTO>();
            List<SignUp> SearchActiveShopList = _db.SignUps.Where(x => x.FullName.Contains(searchName)&& x.LoginType=="Shop" && x.Active==true).ToList();
            foreach (var item in SearchActiveShopList)
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
                SearchActiveShopSignUpDTO.Add(obj);
            }

            return SearchActiveShopSignUpDTO;
        }

        public List<SignUpDTO> SearchPendingShop(string searchName)
        {
            List<SignUpDTO> SearchPendingShopSignUpDTO = new List<SignUpDTO>();
            List<SignUp> SearchPendingShopList = _db.SignUps.Where(x => x.FullName.Contains(searchName) && x.LoginType == "Shop" && x.Active == false).ToList();
            foreach (var item in SearchPendingShopList)
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
                SearchPendingShopSignUpDTO.Add(obj);
            }

            return SearchPendingShopSignUpDTO;
        }

        public List<SignUpDTO> SearchUser(string searchName)
        {
            List<SignUpDTO> SearchUserSignUpDTO = new List<SignUpDTO>();
            List<SignUp> SearchUserList = _db.SignUps.Where(x => x.FullName.Contains(searchName) && x.LoginType == "User").ToList();
            foreach (var item in SearchUserList)
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

                SearchUserSignUpDTO.Add(obj);
            }

            return SearchUserSignUpDTO;
        }

        public SignUpDTO EditDetailsId(int Id)
        {
            SignUp Getobj = _db.SignUps.Where(x => x.SignUpId == Id).FirstOrDefault();
            SignUpDTO GetDetails = new SignUpDTO();

            GetDetails.Active = Getobj.Active;
            GetDetails.Address = Getobj.Address;
            GetDetails.Email = Getobj.Email;
            GetDetails.FullName = Getobj.FullName;
            GetDetails.LoginType = Getobj.LoginType;
            GetDetails.Password = Getobj.Password;
            GetDetails.PhoneNumber = Getobj.PhoneNumber;
            GetDetails.SignUpId = Getobj.SignUpId;

            return GetDetails;
        }

        public void EditDetails(SignUpDTO obj)
        {
            SignUp signupobj = _db.SignUps.Where(x => x.SignUpId == obj.SignUpId).FirstOrDefault();

            signupobj.Active = obj.Active;
            signupobj.Address = obj.Address;
            signupobj.Email = obj.Email;
            signupobj.FullName = obj.FullName;
            signupobj.LoginType = obj.LoginType;
            signupobj.Password = obj.Password;
            signupobj.PhoneNumber = obj.PhoneNumber;
            signupobj.SignUpId = obj.SignUpId;

            _db.Entry(signupobj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public SignUpDTO DeleteDetailsId(int Id)
        {
            SignUp Getobj = _db.SignUps.Where(x => x.SignUpId == Id).FirstOrDefault();
            SignUpDTO GetDetails = new SignUpDTO();

            GetDetails.Active = Getobj.Active;
            GetDetails.Address = Getobj.Address;
            GetDetails.Email = Getobj.Email;
            GetDetails.FullName = Getobj.FullName;
            GetDetails.LoginType = Getobj.LoginType;
            GetDetails.Password = Getobj.Password;
            GetDetails.PhoneNumber = Getobj.PhoneNumber;
            GetDetails.SignUpId = Getobj.SignUpId;

            return GetDetails;
        }

        public void DeleteDetails(int Id)
        {
            SignUp signupobj = _db.SignUps.Where(x => x.SignUpId == Id).FirstOrDefault();
            _db.Entry(signupobj).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
        }

        public SignUpDTO GetUserDetails(int id)
        {
            SignUp Getobj = _db.SignUps.Where(x => x.SignUpId == id).FirstOrDefault();
            SignUpDTO GetDetails = new SignUpDTO();

            GetDetails.Active = Getobj.Active;
            GetDetails.Address = Getobj.Address;
            GetDetails.Email = Getobj.Email;
            GetDetails.FullName = Getobj.FullName;
            GetDetails.LoginType = Getobj.LoginType;
            GetDetails.Password = Getobj.Password;
            GetDetails.PhoneNumber = Getobj.PhoneNumber;
            GetDetails.SignUpId = Getobj.SignUpId;

            return GetDetails;
        }
    }
}
