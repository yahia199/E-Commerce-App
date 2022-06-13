using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.UserCategories
{
    public class ListModel : PageModel
    {
        
        private ICategory CategoryService;

        [BindProperty]
        public List<Product> Products { get; set; }

        [BindProperty]
        public Category category { get; set; }

        public ListModel(ICategory service)
        {
            CategoryService = service;
        }

        public async Task OnGet(int id)
        {
            category = await CategoryService.GetCategory(id);
        }
    }
}
