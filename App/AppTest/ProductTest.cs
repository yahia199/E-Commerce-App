using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppTest
{
  public  class ProductTest
    {
        [Fact]
        public void CanGetProduct()
        {

            Product product = new Product();
            product.Name = "Iphone 13";

            Assert.Equal("Iphone 13", product.Name);
        }
        [Fact]
        public void CanSetProduct()
        {

            Product product = new Product()
            {
                Name = "Iphone 13",
                Price = 1000,
            };
            product.Name = "Iphone 13 Pro Max";

            Assert.Equal("Iphone 13 Pro Max", product.Name);
        }
        [Fact]
        public async void CrudProductInDB()
        {
           
            DbContextOptions<ShopDbContext> options =
            new DbContextOptionsBuilder<ShopDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            using (ShopDbContext context = new ShopDbContext(options))
            {
                Product product = new Product();
                product.Name = "Iphone 13 Pro Max";
                product.Price = 1200;
               

                context.Products.Add(product);
                context.SaveChanges();
                var productName = await context.Products.FirstOrDefaultAsync(x => x.Name == product.Name);

                Assert.Equal("Iphone 13 Pro Max", productName.Name);

                product.Name = "Update Product";
                context.Products.Update(product);
                context.SaveChanges();
                var updatedProduct = await context.Products.FirstOrDefaultAsync(x => x.Name == product.Name);
                Assert.Equal("Update Product", updatedProduct.Name);

                context.Products.Remove(product);
                context.SaveChanges();
                var deletedProduct = await context.Products.FirstOrDefaultAsync(x => x.Name == product.Name);
                Assert.True(deletedProduct == null);
            }
        }
    }
}
