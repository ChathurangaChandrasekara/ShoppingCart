using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Areas.Administration.Models
{
    public class LoginMessaageDTO
    {
        public string Message { get; set; }

        public string LoginType { get; set; }

        public string Email { get; set; }

        public bool? Active { get; set; }
    }
}
