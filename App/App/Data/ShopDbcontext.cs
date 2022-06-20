using App.Auth.Model;
using App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data
{
    public class ShopDbContext : IdentityDbContext<ApplicationUser>
    {

        // there should be a students table with student records in it.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This calls the base method, but does nothing
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "Beauty" },
              new Category { Id = 2, Name = "Clothes", ImgUrl= "https://images.pexels.com/photos/2872879/pexels-photo-2872879.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
              new Category { Id = 3, Name = "Mobiles" , ImgUrl= "https://images.pexels.com/photos/207589/pexels-photo-207589.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
              new Category { Id = 4, Name = "Computers & accessories", ImgUrl= "https://images.pexels.com/photos/2253834/pexels-photo-2253834.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
              new Category { Id = 5, Name = "TV & Home Entertainment" },
              new Category { Id = 6, Name = "Furniture" });

            modelBuilder.Entity<Product>().HasData(
                //  new Product { Id = 1, Name = "Iphone13", Price = 1000, Description = "Test 1", CategoryId = 1 },
                new Product { Id = 2, Name = "Toy", Price = 100, Description = "Test 2", CategoryId = 2 },
                new Product { Id = 3, Name = "Tshirt", Price = 10, Description = "Test 3", CategoryId = 3 },
                new Product { Id = 4, Name = "Shoes", Price = 20, Description = "Test 4", CategoryId = 4 });

            SeedRole(modelBuilder, "Administrator", "Administrator", "Editor");
            SeedRole(modelBuilder, "Editor", "Editor");
            SeedRole(modelBuilder, "Customer");


        }
        private int nextId = 1; 
        private void SeedRole(ModelBuilder modelBuilder, string roleName, params string[] permissions)
        {
            var role = new IdentityRole
            {
                Id = roleName.ToLower(),
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()
            };
            modelBuilder.Entity<IdentityRole>().HasData(role);
            
            var roleClaims = permissions.Select(permission =>
            new IdentityRoleClaim<string>
            {
                Id = nextId++,
                RoleId = role.Id,
                ClaimType = "permissions", 
                ClaimValue = permission
            }).ToArray();
            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(roleClaims);
        }
    }
}
