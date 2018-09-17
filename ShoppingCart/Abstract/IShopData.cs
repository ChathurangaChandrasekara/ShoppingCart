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
        void AddMoreShopDetail(MoreDetailDTO obj);

        AllDataDTO MoreDetailId(int id);
        void EditedDetail(AllDataDTO obj);

        AllDataDTO ShowAllDetail(int id);
    }
}
