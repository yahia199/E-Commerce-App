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
              new Category { Id = 1, Name = "Clothes", ImgUrl= "https://images.pexels.com/photos/2872879/pexels-photo-2872879.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
              new Category { Id = 2, Name = "Mobiles" , ImgUrl= "https://images.pexels.com/photos/207589/pexels-photo-207589.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
              new Category { Id = 3, Name = "Beauty", ImgUrl= "https://images.pexels.com/photos/2253834/pexels-photo-2253834.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }

              //new Category { Id = 4, Name = "Beauty" },
              //new Category { Id = 5, Name = "TV & Home Entertainment" },
              //new Category { Id = 6, Name = "Furniture" }
              );

            modelBuilder.Entity<Product>().HasData(
               
                new Product { Id = 1, Name = "Iphone 13", Price = 1000, Description = "Huge camera upgrades. New OLED display with ProMotion. Fastest smartphone chip ever. Breakthrough battery life.", CategoryId = 2 , ImageUrl= "https://images.pexels.com/photos/9867096/pexels-photo-9867096.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                new Product { Id = 2, Name = "Samsung s 22", Price = 850, Description = "Introducing Galaxy S22; The First Smartphone To Feature Corning® Gorilla® Glass Victus®+ Nightography Camera, Storage To Hold All Your Night Shots ", CategoryId = 2 , ImageUrl= "https://images.pexels.com/photos/11772525/pexels-photo-11772525.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                new Product { Id = 3, Name = "Huawei Mate 30 pro", Price = 750, Description = "The HUAWEI Mate 30 Pro features the Kirin 990 chipset and new EMUI10 for enhanced speed and performance.", CategoryId = 2 , ImageUrl= "https://fscl01.fonpit.de/userfiles/7043987/image/Huawei-Mate-30-Pro/AndroidPIT-huawei-mate-30-pro-mai_n-camera.jpg" },
              
                new Product { Id = 4, Name = "Jacket", Price = 30, Description = "Men Ripped Washed Denim Jacket", CategoryId = 1, ImageUrl= "https://img.ltwebstatic.com/images3_pi/2021/12/17/1639709464654c7e2ed215d07ed68c62c719249af2_thumbnail_900x.webp" },
                new Product { Id = 5, Name = "Jeans", Price = 15, Description = "Men Ripped Frayed Skinny Jeans", CategoryId = 1 , ImageUrl= "https://img.ltwebstatic.com/images3_pi/2021/11/01/1635759829f30e9606b61a22b3c8b9b314d6425fb6_thumbnail_900x.webp" },
                new Product { Id = 6, Name = "Shirt", Price = 750, Description = "Men Button Front Solid Shirt", CategoryId = 1, ImageUrl= "https://img.ltwebstatic.com/images3_pi/2022/03/21/164785138330ce413b577106f77813e7b87489d507_thumbnail_900x.webp" },

                new Product { Id = 7, Name = "Eyeliner", Price = 5, Description = "SHEGLAM Wing It Waterproof Liner Duo - Black", CategoryId = 3, ImageUrl = "https://img.ltwebstatic.com/images3_pi/2020/11/04/160448388566cbde6e32739ed3613a2039882cd1ce_thumbnail_900x.webp" },
                new Product { Id = 8, Name = "Eyeshadow", Price = 10, Description = "SHEGLAM Smart Cookie Palette", CategoryId = 3, ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/03/16/16474155697760b39c9ccd0cfbc395963be1a0605f_thumbnail_900x.webp" },
                new Product { Id = 9, Name = "Foundation", Price = 15, Description = " Long Lasting Breathable Matte Foundation-Fair", CategoryId = 3, ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/03/16/1647408191a4e2d4e9b275a0439d296b96389b68ea_thumbnail_900x.webp" }


                );



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
