﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        public Item item { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
       
    }
}
