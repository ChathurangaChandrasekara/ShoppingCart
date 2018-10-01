using Microsoft.EntityFrameworkCore;
using ShoppingCart.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Areas.Shop.Models;

namespace ShoppingCart.Models
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options)
        { }

        public DbSet<SignUp> SignUps { get; set; }

        public DbSet<MoreDetail> MoreDetails { get; set; }

        public DbSet<ItemCategory> ItemCategories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<ShoppingCart.Areas.Administration.Models.SignUpDTO> SignUpDTO { get; set; }

        public DbSet<ShoppingCart.Areas.Shop.Models.ItemCategoryDTO> ItemCategoryDTO { get; set; }

        public DbSet<ShoppingCart.Areas.Shop.Models.ItemDTO> ItemDTO { get; set; }


    }
}
