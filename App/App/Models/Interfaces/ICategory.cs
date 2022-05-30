using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Interfaces
{
    public interface ICategory
    {

        Task<Category> Create(Category category);
        Task<Category> GetCategory(int id);
        Task<List<Category>> GetCategories();
        Task<Category> UpdateCategory(int id, Category category);
        Task Delete(int id);
    }
}
