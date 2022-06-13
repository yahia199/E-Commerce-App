using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using App.Auth.Dto;
using App.Auth.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.Account
{
    public class loginModel : PageModel
    {

        private IUserService UserService;

        public loginModel(IUserService service)
        {
            UserService = service;
        }


        [BindProperty]
        public LoginDTO LoginDTO { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            
        }
    }

  
}
