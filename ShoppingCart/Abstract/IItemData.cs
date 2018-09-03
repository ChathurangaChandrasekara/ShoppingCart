using ShoppingCart.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IItemData
    {
        void AddItem(ItemDTO obj);

        ItemDTO EditItemId(int id);
        void EditedItem(ItemDTO obj);

        List<ItemDTO> ItemList (int id);

        ItemDTO GetDeleteItem(int id);
        void Delete(int id);
    }
}
