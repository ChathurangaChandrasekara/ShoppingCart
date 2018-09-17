using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Areas.Administration.Models;
using ShoppingCart.Models;

namespace ShoppingCart.Areas.Shop.Models
{
    public class AllDataDTO
    {
        public SignUp signUps { get; internal set; }
        [Key]
        public int SignUpId { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool? Active { get; set; }
        public string LoginType { get; set; }

        public MoreDetail moreDetail { get; internal set; }
        public int MoreDetailId { get; set; }
        public string AdditionPhoneNumber { get; set; }
        public string AdditionAddress { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
    }
}
