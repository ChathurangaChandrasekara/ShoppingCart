using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class MoreDetail
    {
        [Key]
        public int MoreDetailId { get; set; }

        public string AdditionPhoneNumber { get; set; }
        public string AdditionAddress { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }

        public SignUp signUp { get; set; }


    }
}
