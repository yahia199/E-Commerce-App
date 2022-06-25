﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20220625164531_added db")]
    partial class addeddb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Auth.Model.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImgUrl = "https://images.pexels.com/photos/2872879/pexels-photo-2872879.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 2,
                            ImgUrl = "https://images.pexels.com/photos/207589/pexels-photo-207589.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Mobiles"
                        },
                        new
                        {
                            Id = 3,
                            ImgUrl = "https://images.pexels.com/photos/2253834/pexels-photo-2253834.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Beauty"
                        });
                });

            modelBuilder.Entity("App.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("App.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("App.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Huge camera upgrades. New OLED display with ProMotion. Fastest smartphone chip ever. Breakthrough battery life.",
                            ImageUrl = "https://images.pexels.com/photos/9867096/pexels-photo-9867096.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Iphone 13",
                            Price = 1000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Introducing Galaxy S22; The First Smartphone To Feature Corning® Gorilla® Glass Victus®+ Nightography Camera, Storage To Hold All Your Night Shots ",
                            ImageUrl = "https://images.pexels.com/photos/11772525/pexels-photo-11772525.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Samsung s 22",
                            Price = 850
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "The HUAWEI Mate 30 Pro features the Kirin 990 chipset and new EMUI10 for enhanced speed and performance.",
                            ImageUrl = "https://fscl01.fonpit.de/userfiles/7043987/image/Huawei-Mate-30-Pro/AndroidPIT-huawei-mate-30-pro-mai_n-camera.jpg",
                            Name = "Huawei Mate 30 pro",
                            Price = 750
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Men Ripped Washed Denim Jacket",
                            ImageUrl = "https://img.ltwebstatic.com/images3_pi/2021/12/17/1639709464654c7e2ed215d07ed68c62c719249af2_thumbnail_900x.webp",
                            Name = "Jacket",
                            Price = 30
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Men Ripped Frayed Skinny Jeans",
                            ImageUrl = "https://img.ltwebstatic.com/images3_pi/2021/11/01/1635759829f30e9606b61a22b3c8b9b314d6425fb6_thumbnail_900x.webp",
                            Name = "Jeans",
                            Price = 15
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Men Button Front Solid Shirt",
                            ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/03/21/164785138330ce413b577106f77813e7b87489d507_thumbnail_900x.webp",
                            Name = "Shirt",
                            Price = 750
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "SHEGLAM Wing It Waterproof Liner Duo - Black",
                            ImageUrl = "https://img.ltwebstatic.com/images3_pi/2020/11/04/160448388566cbde6e32739ed3613a2039882cd1ce_thumbnail_900x.webp",
                            Name = "Eyeliner",
                            Price = 5
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "SHEGLAM Smart Cookie Palette",
                            ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/03/16/16474155697760b39c9ccd0cfbc395963be1a0605f_thumbnail_900x.webp",
                            Name = "Eyeshadow",
                            Price = 10
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = " Long Lasting Breathable Matte Foundation-Fair",
                            ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/03/16/1647408191a4e2d4e9b275a0439d296b96389b68ea_thumbnail_900x.webp",
                            Name = "Foundation",
                            Price = 15
                        });
                });

            modelBuilder.Entity("App.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "administrator",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "editor",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "customer",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permissions",
                            ClaimValue = "Administrator",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "permissions",
                            ClaimValue = "Editor",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "permissions",
                            ClaimValue = "Editor",
                            RoleId = "editor"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Models.Order", b =>
                {
                    b.HasOne("App.Auth.Model.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("App.Models.OrderItem", b =>
                {
                    b.HasOne("App.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("App.Models.Product", b =>
                {
                    b.HasOne("App.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("App.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("App.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("App.Auth.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("App.Auth.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Auth.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("App.Auth.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("App.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
