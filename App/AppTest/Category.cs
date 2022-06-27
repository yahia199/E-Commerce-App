using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace AppTest
{
    public class Categories
    {
        [Fact]
        public void CanGetCategory()
        {
            //Arrange
            Category category = new Category();
            category.Name = "Mobiles";

            //Assert
            Assert.Equal("Mobiles", category.Name);
        }
        [Fact]
        public void CanSetCategory()
        {
            //Arrange
            Category category = new Category()
            {
                Name = "Mobiles",

            };
            category.Name = "Mobile";
            //Assert
            Assert.Equal("Mobile", category.Name);
        }
        [Fact]
        public async void CrudCategoryInDB()
        {
            //Arrange
            //setup our DB
            //set values

            DbContextOptions<ShopDbContext> options =
            new DbContextOptionsBuilder<ShopDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            //Act
            using (ShopDbContext context = new ShopDbContext(options))
            {
                Category category = new Category();
                category.Name = "Test";


                ////Act

                context.categories.Add(category);
                context.SaveChanges();

                var categoryName = await context.categories.FirstOrDefaultAsync(x => x.Name == category.Name);

                //Assert
                Assert.Equal("Test", categoryName.Name);

                //UPDATE
                category.Name = "Update category";
                context.categories.Update(category);
                context.SaveChanges();

                var updatedcategory = await context.categories.FirstOrDefaultAsync(x => x.Name == category.Name);

                Assert.Equal("Update category", updatedcategory.Name);

                //DELETE
                context.categories.Remove(category);
                context.SaveChanges();

                var delete = await context.categories.FirstOrDefaultAsync(x => x.Name == category.Name);

                Assert.True(delete == null);
            }

        }
    }
}
