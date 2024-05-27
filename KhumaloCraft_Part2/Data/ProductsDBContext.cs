using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft_Part2.Models;

namespace KhumaloCraft_Part2.Data
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext (DbContextOptions<ProductsDBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Seller>().ToTable("Seller");
            modelBuilder.Entity<User>().ToTable("User");
        }

        public DbSet<KhumaloCraft_Part2.Models.Product> Product { get; set; } = default!;
    }
}
