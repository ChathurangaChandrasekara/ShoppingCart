using ShoppingCart.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IAdminData
    {
        List<SignUpDTO> GetActiveShop();
        List<SignUpDTO> GetPendingShop();
        List<SignUpDTO> GetUser();
        List<SignUpDTO> SearchActiveShop(string searchName);
        List<SignUpDTO> SearchPendingShop(string searchName);
        List<SignUpDTO> SearchUser(string searchName);
        SignUpDTO EditDetailsId(int Id);
        void EditDetails(SignUpDTO obj);
        SignUpDTO DeleteDetailsId(int Id);
        void DeleteDetails(int Id);
        SignUpDTO GetUserDetails(int id);

    }
}
