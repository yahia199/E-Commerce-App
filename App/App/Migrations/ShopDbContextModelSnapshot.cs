﻿// <auto-generated />
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobiles"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Computers & accessories"
                        },
                        new
                        {
                            Id = 5,
                            Name = "TV & Home Entertainment"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Furniture"
                        });
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
                            CategoryId = 1,
                            Description = "Test 1",
                            Name = "Iphone13",
                            Price = 1000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Test 2",
                            Name = "Toy",
                            Price = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Test 3",
                            Name = "Tshirt",
                            Price = 10
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Description = "Test 4",
                            Name = "Shoes",
                            Price = 20
                        });
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

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
