using ShoppingCart.Abstract;
using ShoppingCart.Areas.Shop.Models;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Concrete
{
    public class ItemCategoryData : IItemCategoryData
    {
        private readonly ShoppingCartDbContext _db;
        public ItemCategoryData(ShoppingCartDbContext db)
        {
            _db = db;
        }

       
        public List<ItemCategoryDTO> ShowList(int id)
        {
            List<ItemCategoryDTO> list = new List<ItemCategoryDTO>();
            List<ItemCategory> GetList = _db.ItemCategories.Where(x => x.SignUpId == id).ToList();

            foreach (var item in GetList)
            {
                ItemCategoryDTO obj = new ItemCategoryDTO();
                obj.ItemCategoryId = item.ItemCategoryId;
                obj.ItemCategoryName = item.ItemCategoryName;
                obj.SignUpId = item.SignUpId;

                list.Add(obj);
            }
            return list;
        }

        public ItemCategoryDTO EditById(int id)
        {
            ItemCategoryDTO Get = new ItemCategoryDTO();
            ItemCategory GetItemCategory = _db.ItemCategories.Where(x => x.ItemCategoryId == id).FirstOrDefault();

            Get.SignUpId = GetItemCategory.SignUpId;
            Get.ItemCategoryId = GetItemCategory.ItemCategoryId;
            Get.ItemCategoryName = GetItemCategory.ItemCategoryName;

            return Get;
        }

        public void Edited(ItemCategoryDTO obj)
        {
            ItemCategory EditedCategory = _db.ItemCategories.Where(x => x.ItemCategoryId == obj.ItemCategoryId).FirstOrDefault();
            _db.Entry(EditedCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public ItemCategoryDTO DeleteById(int delete, int id)
        {
            ItemCategory GetById = _db.ItemCategories.Where(x => x.ItemCategoryId == delete).FirstOrDefault();
            ItemCategoryDTO GetObj = new ItemCategoryDTO();

            GetObj.ItemCategoryId = GetById.ItemCategoryId;
              GetObj.ItemCategoryName = GetById.ItemCategoryName;
            GetObj.SignUpId = GetById.SignUpId;

            return GetObj;
        }

        public void Deleted(int delete, int id)
        {
            ItemCategory DeleteCategory = _db.ItemCategories.Where(x => x.ItemCategoryId == delete).FirstOrDefault();
            _db.Entry(DeleteCategory).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
        }


        public void Created(ItemCategoryDTO obj)
        {
            ItemCategory Create = new ItemCategory();

            Create.ItemCategoryName = obj.ItemCategoryName;
            Create.SignUpId = obj.SignUpId;

            _db.Add(Create);
            _db.SaveChanges();
           
        }

        
    }
}
