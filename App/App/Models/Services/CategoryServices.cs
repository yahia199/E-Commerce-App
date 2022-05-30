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
            var Categories = await _context.Category.ToListAsync();
            return Categories;
        }

        public async Task<Category> GetCategory(int id)
        {
            Category Category = await _context.Category.FindAsync(id);
            return Category;
        }

        public async Task<Category> UpdateCategory(int id, Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
