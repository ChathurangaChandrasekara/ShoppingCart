using Microsoft.EntityFrameworkCore;
using ShoppingCart.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options) : base(options)
        { }

        public DbSet<SignUp> SignUps { get; set; }

        public DbSet<ShoppingCart.Areas.Administration.Models.SignUpDTO> SignUpDTO { get; set; }
    }
}
