using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IShopData
    {
        SignUpDTO ShopDetailId(int id);
        void EditAllShopDetail(MoreDetailDTO obj);
    }
}
