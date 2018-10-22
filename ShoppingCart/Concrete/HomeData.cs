using ShoppingCart.Abstract;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class HomeData : IHomeData
    {
        private readonly ShoppingCartDbContext _db;
        public HomeData(ShoppingCartDbContext db)
        {
            _db = db;
        }

        public List<ItemDTO> ItemListData1(int id)
        {
            List<ItemDTO> ItemList1 = new List<ItemDTO>();
            List<Item> ListItem = _db.Items.Where(x => x.ItemCategoryId == 12).ToList();

            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                ItemList1.Add(obj);
            }
            return ItemList1;
        }

        public List<ItemDTO> ItemListData2(int id)
        {
            List<ItemDTO> ItemList2 = new List<ItemDTO>();
            List<Item> ListItem = _db.Items.Where(x => x.ItemCategoryId == id).ToList();

            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                ItemList2.Add(obj);
            }
            return ItemList2;
        }

        public List<ItemDTO> ItemListData3(int id)
        {
            List<ItemDTO> ItemList3 = new List<ItemDTO>();
            List<Item> ListItem = _db.Items.Where(x => x.ItemCategoryId == id).ToList();

            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                ItemList3.Add(obj);
            }
            return ItemList3;
        }

        public List<ItemDTO> ItemListData4(int id)
        {
            List<ItemDTO> ItemList4 = new List<ItemDTO>();
            List<Item> ListItem = _db.Items.Where(x => x.ItemCategoryId == id).ToList();

            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                ItemList4.Add(obj);
            }
            return ItemList4;
        }

        public List<ItemDTO> ItemListData5(int id)
        {
            List<ItemDTO> ItemList5 = new List<ItemDTO>();
            List<Item> ListItem = _db.Items.Where(x => x.ItemCategoryId == id).ToList();

            foreach (var item in ListItem)
            {
                ItemDTO obj = new ItemDTO();

                obj.Description = item.Description;
                obj.ImageUrl1 = item.ImageUrl1;
                obj.ImageUrl2 = item.ImageUrl2;
                obj.ImageUrl3 = item.ImageUrl3;
                obj.ImageUrl4 = item.ImageUrl4;
                obj.itemCategory = item.itemCategory;
                obj.ItemCode = item.ItemCode;
                obj.ItemId = item.ItemId;
                obj.ItemName = item.ItemName;
                obj.Quantity = item.Quantity;
                obj.UnitPrice = item.UnitPrice;
                obj.SignUpId = item.SignUpId;
                obj.ItemCategoryId = item.ItemCategoryId;



                ItemList5.Add(obj);
            }
            return ItemList5;
        }

       
    }
}
