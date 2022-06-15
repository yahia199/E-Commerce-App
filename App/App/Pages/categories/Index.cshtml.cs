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
    public class IndexModel : PageModel
    {
        private readonly ICategory _Category;

        public IndexModel(ICategory category )
        {
            _Category = category;
        }
        public List<Category> categories { get; set; }

        public async Task OnGet()
        {
            categories = await _Category.GetCategories();

        }
    }
}
