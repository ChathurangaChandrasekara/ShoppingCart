using Microsoft.AspNetCore.Http;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ShoppingCart.Areas.Shop.Models
{
    public class ItemDTO
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        [DisplayName("Image")]
        public string ImageUrl { get; set; }

        public List<IFormFile> ImageFile { get; set; }

        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public ItemCategory itemCategory;
        public int ItemCategoryId { get; set; }


        public SignUp signUp;
        public int SignUpId { get; set; }
    }
}
