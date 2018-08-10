using ShoppingCart.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
   public interface ILoginData
    {
        List<SignUpDTO> getAllLoginData();
        void  setAllLoginData(SignUpDTO signobj);
        LoginMessaageDTO checkLogin(LoginDTO loginobj);
    }
}
