using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Administration.Models
{
    

    public class SignUpDTO
    {
        [Key]
        public int SignUpId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Unique]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(10,ErrorMessage ="Invalid Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(8,ErrorMessage ="Minimum 8 characters required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        public bool? Active { get; set; }

        public string LoginType { get; set; }
        [NotMapped]
        public List<SelectListItem> Types { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "Shop", Text = "Shop" },
        new SelectListItem { Value = "User", Text = "User" },
        
    };
    }
}
