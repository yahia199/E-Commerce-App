using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data
{
    public class ShopDbContext : DbContext
    {
        internal object products;

        // there should be a students table with student records in it.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This calls the base method, but does nothing
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "Beauty" },
              new Category { Id = 2, Name = "Clothes" },
              new Category { Id = 3, Name = "Mobiles" },
              new Category { Id = 4, Name = "Computers & accessories" },
              new Category { Id = 5, Name = "TV & Home Entertainment" },
              new Category { Id = 6, Name = "Furniture" });

            modelBuilder.Entity<Product>().HasData(
              //  new Product { Id = 1, Name = "Iphone13", Price = 1000, Description = "Test 1", CategoryId = 1 },
                new Product { Id = 2, Name = "Toy", Price = 100, Description = "Test 2", CategoryId = 2 },
                new Product { Id = 3, Name = "Tshirt", Price = 10, Description = "Test 3", CategoryId = 3 },
                new Product { Id = 4, Name = "Shoes", Price = 20, Description = "Test 4", CategoryId = 4 });

        }
    }
}
