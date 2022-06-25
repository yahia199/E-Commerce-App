using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.Interfaces
{
    public interface IProduct
    {
        Task<Product> Create(Product product);
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProducts();
        Task<Product> UpdateProduct(Category category, Product product);
        Task Delete(int id);


    }
}
