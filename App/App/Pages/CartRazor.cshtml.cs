using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages
{
    public class CartRazorModel : PageModel
    {
        public string Products { get; set; }

        public void OnGet()
        {
            Products = Request.Cookies["CartCookie"];
        }


    }
}

