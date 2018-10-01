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

        public void AddItem(ItemDTO obj)
        {
            //Item AddItemDetails = _db.Items.Where(x => x.SignUpId == obj.SignUpId).FirstOrDefault();
            Item AddItemDetails = new Item();

            AddItemDetails.ItemName = obj.ItemName;
            AddItemDetails.ItemCode = obj.ItemCode;
            AddItemDetails.ImageUrl1 = obj.ImageUrl1;
            AddItemDetails.ImageUrl2 = obj.ImageUrl2;
            AddItemDetails.ImageUrl3 = obj.ImageUrl3;
            AddItemDetails.ImageUrl4 = obj.ImageUrl4;
            AddItemDetails.Description = obj.Description;
            AddItemDetails.Quantity = obj.Quantity;
            AddItemDetails.UnitPrice = obj.UnitPrice;
            AddItemDetails.SignUpId = obj.SignUpId;
            AddItemDetails.ItemCategoryId = obj.ItemCategoryId;
            

            _db.Entry(AddItemDetails).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _db.SaveChanges();
            
        }

        public ItemDTO EditItemId(int id)
        {
            ItemDTO GetItemDetail = new ItemDTO();
            Item GetItemDetailId = _db.Items.Where(x => x.ItemId == id).FirstOrDefault();

            GetItemDetail.Description = GetItemDetailId.Description;
            GetItemDetail.ImageUrl1 = GetItemDetailId.ImageUrl1;
            GetItemDetail.itemCategory = GetItemDetailId.itemCategory;
            GetItemDetail.ItemCode = GetItemDetailId.ItemCode;
            GetItemDetail.ItemId = GetItemDetailId.ItemId;
            GetItemDetail.ItemName = GetItemDetailId.ItemName;
            GetItemDetail.Quantity = GetItemDetailId.Quantity;
            GetItemDetail.UnitPrice = GetItemDetailId.UnitPrice;
            
            return GetItemDetail;
        }

        public void EditedItem(ItemDTO obj)
        {
            Item EditedItemDetail = _db.Items.Where(x => x.signUp.SignUpId == obj.signUp.SignUpId).FirstOrDefault();

            EditedItemDetail.Description = obj.Description;
            EditedItemDetail.ImageUrl1 = obj.ImageUrl1;
            EditedItemDetail.itemCategory = obj.itemCategory;
            EditedItemDetail.ItemCode = obj.ItemCode;
            EditedItemDetail.ItemId = obj.ItemId;
            EditedItemDetail.ItemName = obj.ItemName;
            EditedItemDetail.Quantity = obj.Quantity;
            EditedItemDetail.UnitPrice = obj.UnitPrice;

            _db.Entry(EditedItemDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public List<ItemDTO> ItemList(int id)
        {
            List<ItemDTO> ItemList = new List<ItemDTO>();
            List<Item> ListItem = _db.Items.Where(x => x.SignUpId == id).ToList();

            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;
                

                ItemList.Add(obj);
            }
            return ItemList;
        }

        public ItemDTO GetDeleteItem(int id)
        {
            Item GetItem = _db.Items.Where(x => x.ItemId == id).FirstOrDefault();
            ItemDTO GetItemDTO = new ItemDTO();

            GetItemDTO.Description = GetItem.Description;
            GetItemDTO.ImageUrl1 = GetItem.ImageUrl1;
            GetItemDTO.itemCategory = GetItem.itemCategory;
            GetItemDTO.ItemCode = GetItem.ItemCode;
            GetItemDTO.ItemId = GetItem.ItemId;
            GetItemDTO.ItemName = GetItem.ItemName;
            GetItemDTO.Quantity = GetItem.Quantity;
            GetItemDTO.signUp = GetItem.signUp;
            GetItemDTO.UnitPrice = GetItem.UnitPrice;

            return GetItemDTO;
        }

        public void Delete(int delete)
        {
            Item DeleteItem = _db.Items.Where(x => x.ItemId == delete).FirstOrDefault();
            _db.Entry(DeleteItem).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
        }

        public ItemDTO Details(int id)
        {
            Item getItem = _db.Items.Where(x => x.ItemId == id).FirstOrDefault();
            ItemDTO obj = new ItemDTO();
            obj.Description = getItem.Description;
            //obj.ImageFile = getItem.i;
            obj.ImageUrl1 = getItem.ImageUrl1;
            obj.ItemCategoryId = getItem.ItemCategoryId;
            obj.ItemCode = getItem.ItemCode;
            obj.ItemId = getItem.ItemId;
            obj.ItemName = getItem.ItemName;
            obj.Quantity = getItem.Quantity;
            obj.UnitPrice = getItem.UnitPrice;
            return obj;
        }
    }

}
