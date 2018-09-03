using ShoppingCart.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IItemCategoryData
    {
        List<ItemCategoryDTO> ShowList(int id);

        ItemCategoryDTO EditById(int id);
        void Edited(ItemCategoryDTO obj);

        ItemCategoryDTO DeleteById(int id,int delete);
        void Deleted(int delete, int id);

        
        void Created(ItemCategoryDTO obj);
    }
}
