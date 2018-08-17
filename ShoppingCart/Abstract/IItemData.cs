using ShoppingCart.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Abstract
{
    public interface IItemData
    {
        ItemDTO AddItem(int Id);
    }
}
