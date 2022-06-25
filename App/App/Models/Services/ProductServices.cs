using App.Data;
using App.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Services
{
    public class ProductServices : IProduct
    {
        private readonly ShopDbContext _context;

        public ProductServices(ShopDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Create(Product product)
        {
            _context.Entry(product).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task Delete(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            _context.Entry(product).State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var Products = await _context.Products.ToListAsync();
            return Products;
        }

        public async Task<Product> UpdateProduct(Category category, Product product)
        {
            product.Category = category;

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;

        }
       
    }
}
