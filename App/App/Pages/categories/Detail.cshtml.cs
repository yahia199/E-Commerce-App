using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.categories
{
    public class DetailModel : PageModel
    {
        private readonly ICategory _category;
        public List<Product> products;

        private IProduct _product;
        public DetailModel(ICategory category)
        {
            _category = category;
        }

        public Category category { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            category = await _category.GetCategory(id);

            return Page();
        }
        public async void OnPost(int id)
        {
            var Product = await _product.GetProduct(id);
            products.Add(Product);
        }

    }
}
