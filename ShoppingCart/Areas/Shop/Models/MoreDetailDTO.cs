using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Shop.Models
{
    public class MoreDetailDTO
    {

        [Key]
        public int MoreDetailId { get; set; }

        public string AdditionPhoneNumber { get; set; }
        public string AdditionAddress { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }

        public SignUp signUp;
        public int SignUpId { get; set; }
    }
}
