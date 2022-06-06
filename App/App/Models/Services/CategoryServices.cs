using App.Data;
using App.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Services
{
    public class CategoryServices : ICategory
    {
        private readonly ShopDbContext _context;

        public CategoryServices(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Create(Category category)
        {
            _context.Entry(category).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return category;

        }

        public async Task Delete(int id)
        {
            Category Category = await GetCategory(id);
            _context.Entry(Category).State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.categories.Select(c => new Category
            {
                Id = c.Id,
                Name = c.Name,
                Products = c.Products.Select(a => new Product
                {
                    Id = a.Id,
                    Name = a.Name,
                    Price = a.Price
                }).ToList()
            }).ToListAsync();
        }

        public async Task<Category> GetCategory(int id)
        {
            return await _context.categories.Select(c => new Category
            {
                 Id = c.Id,
                 Name = c.Name,
                 Products = c.Products.Select(a => new Product 
                 {
                     Id = a.Id,
                     Name = a.Name,
                     Price = a.Price
                 }).ToList()
            }).FirstOrDefaultAsync(x => x.Id==id);
            
        }

        public async Task<Category> UpdateCategory(int id, Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
