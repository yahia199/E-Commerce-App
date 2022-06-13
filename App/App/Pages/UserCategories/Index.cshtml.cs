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
    public class IndexModel : PageModel
    {
        private ICategory categoryService;


        [BindProperty]
        public List<Category> Categories { get; set; }


        public IndexModel(ICategory service)
        {
            categoryService = service;
        }

       
        public async Task OnGet()
        {
            Categories = await categoryService.GetCategories();
        }
    }
}
