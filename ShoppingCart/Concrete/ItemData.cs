using ShoppingCart.Abstract;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class ItemData : IItemData
    {
        private readonly ShoppingCartDbContext _db;
        public ItemData(ShoppingCartDbContext db)
        {
            _db = db;
        }

        public ItemDTO AddItem(int Id)
        {
            ItemDTO AddItemDetails = new ItemDTO();

            AddItemDetails.
            return null;
        }
    }
}
