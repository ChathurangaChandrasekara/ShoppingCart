using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IHomeData
    {
        List<ItemDTO> ItemListData1(int id); 
        List<ItemDTO> ItemListData2(int id);
        List<ItemDTO> ItemListData3(int id);
        List<ItemDTO> ItemListData4(int id);
        List<ItemDTO> ItemListData5(int id);
    }
}
