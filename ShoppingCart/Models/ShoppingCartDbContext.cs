using Microsoft.EntityFrameworkCore;
using ShoppingCart.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Areas.Shop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ShoppingCart.Models
{
    public class ShoppingCartDbContext : IdentityDbContext<IdentityUser>
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options)
        { }

        public DbSet<SignUp> SignUps { get; set; }

        public DbSet<MoreDetail> MoreDetails { get; set; }

        public DbSet<ItemCategory> ItemCategories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        

    }
}
