using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Auth.Dto;
using App.Auth.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages.Account
{
    public class RegisterModel : PageModel
    {

        private IUserService UserService;

        public RegisterModel(IUserService service)
        {
            UserService = service;
        }


        [BindProperty]
        public RegisterDto RegisterDto { get; set; }


        public void OnGet()
        {
        }

        //public async Task OnPost(RegisterDto register)
        //{
        //    var user = await UserService.Register(register, this.ModelState);

        //}
    }
}
