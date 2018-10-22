using ShoppingCart.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IUserData
    {
        SignUpDTO GetUserDetail(int id);
        SignUpDTO GetDetailToEdit(int id);
        void SaveEditDetail(SignUpDTO obj);
    }
}
